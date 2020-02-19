using System;
using System.Collections.Generic;
using Xunit;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;

namespace NetCoreForce.Client.Tests
{
    public class UriFormatterTest
    {
        const string apiVersion = "v41.0";
        const string instanceUrl = "https://xxx.salesforce.com";
        const string SObjectName = "Account";
        const string ObjectId = "001XXXXXXXXXXXXXXX";

        //Note: Uri.AbsoluteUri is fully escaped/URL encoded. UriToString() will leave some chars like spaces as is

        [Fact]
        public void SObjectRows()
        {
            string result = UriFormatter.SObjectRows("https://xxx.salesforce.com", "v41.0", "Account", "001XXXXXXXXXXXXXXX").AbsoluteUri;

            Assert.Equal("https://xxx.salesforce.com/services/data/v41.0/sobjects/Account/001XXXXXXXXXXXXXXX", result);
        }

        [Fact]
        public void SObjectRowsWithSingleField()
        {
            List<string> fields = new List<string>() { "AccountNumber" };
            string result = UriFormatter.SObjectRows("https://xxx.salesforce.com", "v41.0", "Account", "001XXXXXXXXXXXXXXX", fields).AbsoluteUri;

            Assert.Equal("https://xxx.salesforce.com/services/data/v41.0/sobjects/Account/001XXXXXXXXXXXXXXX?fields=AccountNumber", result);
        }

        [Fact]
        public void SObjectRowsWithFields()
        {
            List<string> fields = new List<string>() { "AccountNumber", "BillingPostalCode" };
            string result = UriFormatter.SObjectRows("https://xxx.salesforce.com", "v41.0", "Account", "001XXXXXXXXXXXXXXX", fields).AbsoluteUri;

            Assert.Equal("https://xxx.salesforce.com/services/data/v41.0/sobjects/Account/001XXXXXXXXXXXXXXX?fields=AccountNumber,BillingPostalCode", result);
        }

        [Fact]
        public void SObjectsComposite()
        {
            string result = UriFormatter.SObjectsComposite("https://xxx.salesforce.com", "v41.0").AbsoluteUri;

            Assert.Equal("https://xxx.salesforce.com/services/data/v41.0/composite/sobjects", result);
        }

        [Fact]
        public void SObjectBasicInformation()
        {
            string result = UriFormatter.SObjectBasicInformation("https://xxx.salesforce.com", "v41.0", "Account").AbsoluteUri;

            Assert.Equal("https://xxx.salesforce.com/services/data/v41.0/sobjects/Account", result);
        }

        [Fact]
        public void Query()
        {
            string result = UriFormatter.Query(
                "https://xxx.salesforce.com",
                "v41.0",
                "SELECT Id, Name FROM Account WHERE Id = '001XXXXXXXXXXXXXXX'",
                false).AbsoluteUri;

            Assert.Equal("https://xxx.salesforce.com/services/data/v41.0/query?q=SELECT%20Id,%20Name%20FROM%20Account%20WHERE%20Id%20%3D%20%27001XXXXXXXXXXXXXXX%27",
                result);
        }

        [Fact]
        public void QueryAll()
        {
            string result = UriFormatter.Query(
                "https://xxx.salesforce.com",
                "v41.0",
                "SELECT Id, Name FROM Account WHERE Id = '001XXXXXXXXXXXXXXX'",
                true).AbsoluteUri;            

            Assert.Equal("https://xxx.salesforce.com/services/data/v41.0/queryAll?q=SELECT%20Id,%20Name%20FROM%20Account%20WHERE%20Id%20%3D%20%27001XXXXXXXXXXXXXXX%27",
                result);
        }

        //TODO: Auth URLs

        [Fact]
        public void WebServerAuthenticationUrl()
        {
            // With Uri.ToString() Colon ":" is escaped to %3A on Windows platforms, but not on MacOS. May also affect space " " and asterisk "*"
            // Uri.AbsoluteUri.ToString() appears to normalize this behavior.
            // Specs seem to say that it should be escaped, e.g. RFC 3986
            // May need to verify if any downstream users will need to avoid Uri.ToString() when using the URIs

            string result = UriFormatter.WebServerAuthenticationUrl("https://login.salesforce.com/services/oauth2/authorize", "CLIENTID", "https://www.theredirectpage.com/callback").AbsoluteUri.ToString();

            Assert.Equal("https://login.salesforce.com/services/oauth2/authorize?response_type=code&client_id=CLIENTID&redirect_uri=https%3A%2F%2Fwww.theredirectpage.com%2Fcallback&display=page&immediate=false", result);

            result = UriFormatter.WebServerAuthenticationUrl("https://login.salesforce.com/services/oauth2/authorize", "CLIENTID", "https://www.theredirectpage.com/callback", DisplayTypes.Popup, true, "refresh_token").AbsoluteUri.ToString();

            Assert.Equal("https://login.salesforce.com/services/oauth2/authorize?response_type=code&client_id=CLIENTID&redirect_uri=https%3A%2F%2Fwww.theredirectpage.com%2Fcallback&display=popup&immediate=true&scope=refresh_token", result);

            //TODO: test with url-encoded state parameter
        }
    }
}
