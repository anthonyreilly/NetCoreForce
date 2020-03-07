using System;
using System.IO;
using System.Net;
using System.Net.Http;

namespace NetCoreForce.Client.Tests
{
    public static class MockResponse
    {
        const string subfolder = "responses";
        public static HttpResponseMessage GetResponse(string filename, HttpStatusCode statusCode)
        {
            HttpResponseMessage msg = new HttpResponseMessage(statusCode);
            msg.Content = new StringContent(GetFileContent(filename));

            return msg;
        }

        public static string GetFileContent(string filename)
        {
            try
            {
                string executabledirectory = System.IO.Directory.GetCurrentDirectory();
                string filePath = Path.Combine(executabledirectory, subfolder, filename);
                string contents = File.ReadAllText(filePath);
                return contents;
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Error reading file [{0}]: {1}", filename, ex.Message));
                throw ex;
            }
        }

    }
}
