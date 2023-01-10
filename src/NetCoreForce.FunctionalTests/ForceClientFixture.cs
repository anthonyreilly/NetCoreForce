using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;
using Newtonsoft.Json;

namespace NetCoreForce.FunctionalTests
{
    public class ForceClientFixture : IDisposable
    {
        public AuthInfo AuthInfo { get; private set; }

        private ForceClient _forceClient;

        public ForceClientFixture()
        {
            string filePath = null;
            try
            {
                if (string.IsNullOrEmpty(filePath))
                {
                    string executabledirectory = System.IO.Directory.GetCurrentDirectory();
                    string fileName = "credentials_dev.json";
                    filePath = Path.Combine(executabledirectory, fileName);
                }

                Console.WriteLine("Reading credentials file {0}", filePath);

                string contents = File.ReadAllText(filePath);
                AuthInfo info = JsonConvert.DeserializeObject<AuthInfo>(contents);

                this.AuthInfo = info;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading credentials file: " + ex.Message);
                throw;
            }
        }

        public async Task<ForceClient> GetForceClient(string proxyUrl = null)
        {
            if (_forceClient == null)
            {
                System.Net.Http.HttpClient proxyClient = null;

                if (!string.IsNullOrEmpty(proxyUrl))
                {
                    proxyClient = HttpClientFactory.CreateHttpClient(true, proxyUrl);
                }

                AuthenticationClient auth = new AuthenticationClient();
                await auth.UsernamePasswordAsync(AuthInfo.ClientId, AuthInfo.ClientSecret,
                        AuthInfo.Username, AuthInfo.Password, AuthInfo.TokenRequestEndpoint);
                _forceClient = new ForceClient(auth.AccessInfo.InstanceUrl, auth.ApiVersion, auth.AccessInfo.AccessToken, proxyClient);
            }
            return _forceClient;
        }

        /// <summary>
        /// Create and retreive sObject - to test any changes to object after creation and storage in SF
        /// </summary>
        /// <param name="sObjectTypeName"></param>
        /// <param name="sObject"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public async Task<T> CreateAndRetrieveRecord<T>(string sObjectTypeName, T sObject)
        {
            ForceClient client = await GetForceClient();
            CreateResponse createResp = await client.CreateRecord<T>(sObjectTypeName, sObject);
            T retrievedObject = await client.GetObjectById<T>(sObjectTypeName, createResp.Id);
            return retrievedObject;
        }

        public void Dispose()
        {
        }

    }
}