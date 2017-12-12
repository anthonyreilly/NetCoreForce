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
                throw ex;
            }
        }

        public async Task<ForceClient> GetForceClient(string proxyUrl = null)
        {
            System.Net.Http.HttpClient proxyClient = null;

            if(!string.IsNullOrEmpty(proxyUrl))
            {
                proxyClient  = HttpClientFactory.CreateHttpClient(true, proxyUrl);
            }

            AuthenticationClient auth = new AuthenticationClient();
            await auth.UsernamePasswordAsync(AuthInfo.ClientId, AuthInfo.ClientSecret,
                    AuthInfo.Username, AuthInfo.Password, AuthInfo.TokenRequestEndpoint);
            ForceClient client = new ForceClient(auth.AccessInfo.InstanceUrl, auth.ApiVersion, auth.AccessInfo.AccessToken, proxyClient);
            return client;
        }

        public void Dispose()
        {
        }

    }
}