using System;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;
using NetCoreForce.Models;
using System.Dynamic;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SampleConsole
{
    /// <summary>
    /// Example of inherting a standard object and adding a custom field
    /// </summary>
    public class CustomAccount : SfAccount
    {
        public string CustomerPriority__c { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SampleConsole starting...");
            RunTest().Wait();
            Console.WriteLine("SampleConsole Done");
        }

        private static async Task RunTest()
        {
            AuthInfo authInfo = GetAuthInfo();
            AuthenticationClient auth = new AuthenticationClient(authInfo.ApiVersion);

            try
            {
                await auth.UsernamePasswordAsync(authInfo.ClientId, authInfo.ClientSecret, authInfo.Username, authInfo.Password, authInfo.TokenRequestEndpoint);
                Console.WriteLine("Successfully connected to Salesforce");
            }
            catch (ForceAuthException ex)
            {
                Console.WriteLine("ForceAuthException: " + ex.Message);
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Exception at login: " + ex.Message);
                return;
            }

            try
            {
                ForceClient client = new ForceClient(auth.AccessInfo.InstanceUrl, auth.ApiVersion, auth.AccessInfo.AccessToken);

                List<SfContact> contacts = await client.Query<SfContact>("SELECT Id, Name, SystemModstamp, Account.Id, Account.Name, Account.SystemModstamp FROM Contact", false);

                List<CustomAccount> customAccounts = await client.Query<CustomAccount>("SELECT Id, CustomerPriority__c FROM Account", false);

                //Using a dynamic object
                dynamic dynoObject = new ExpandoObject();
                dynoObject.Name = "Test Account";
                dynoObject.Description = "Test Account description";
                CreateResponse resp = await client.CreateRecord<dynamic>("Account", dynoObject);

                // Asynchronous large result sets and batching:
                // Query<T> method will retrieve the full result set before returning.
                // In cases where you are working with large result sets, you may want to retrieve the batches asynchronously for better performance.

                // First create the async enumerable. At this point, no query has been executed.
                // batchSize can be omitted to use the default (usually 2000), or given a custom value between 200 and 2000.
                IAsyncEnumerable<SfContact> contactsEnumerable = client.QueryAsync<SfContact>("SELECT Id, Name FROM Contact ", batchSize: 200);

                // Get the enumerator, in a using block for proper disposal
                await using (IAsyncEnumerator<SfContact> contactsEnumerator = contactsEnumerable.GetAsyncEnumerator())
                {
                    // MoveNext() will execute the query and get the first batch of results.
                    // Once the inital result batch has been exhausted, the remaining batches, if any, will be retrieved.
                    while (await contactsEnumerator.MoveNextAsync())
                    {
                        SfContact contact = contactsEnumerator.Current;
                        // process your results
                    }
                }

// #if NETSTANDARD2_1
//                 // Get the enumerator, in a using block for proper disposal
//                 await using (IAsyncEnumerator<SfContact> contactsEnumerator = contactsEnumerable.GetAsyncEnumerator())
//                 {
//                     // MoveNext() will execute the query and get the first batch of results.
//                     // Once the inital result batch has been exhausted, the remaining batches, if any, will be retrieved.
//                     while (await contactsEnumerator.MoveNextAsync())
//                     {
//                         SfContact contact = contactsEnumerator.Current;
//                         // process your results
//                     }
//                 }
// #else
//                 // Get the enumerator
//                 IAsyncEnumerator<SfContact> contactsEnumerator = contactsEnumerable.GetAsyncEnumerator();
//                 // MoveNext() will execute the query and get the first batch of results.
//                 // Once the inital result batch has been exhausted, the remaining batches, if any, will be retrieved.
//                 while (await contactsEnumerator.MoveNextAsync())
//                 {
//                     SfContact contact = contactsEnumerator.Current;
//                     // process your results
//                 }

//                 // Dispose the enumerator
//                 await contactsEnumerator.DisposeAsync();
// #endif
            }
            catch (ForceApiException ex)
            {
                Console.WriteLine("ForceApiException: " + ex.Message);
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Exception: " + ex.Message);
                return;
            }

            return;
        }

        /// <summary>
        /// Read a local file with authentication info
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private static AuthInfo GetAuthInfo(string filePath = null)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath))
                {
                    string executabledirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
                    string fileName = "credentials_dev.json";
                    filePath = Path.Combine(executabledirectory, fileName);
                }

                Console.WriteLine("Reading credentials file {0}", filePath);

                string contents = File.ReadAllText(filePath);
                AuthInfo info = JsonConvert.DeserializeObject<AuthInfo>(contents);
                return info;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading credentials file: " + ex.Message);
                throw ex;
            }
        }
    }
}