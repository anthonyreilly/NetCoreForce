using System;
using System.Collections.Generic;
using Xunit;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;

namespace NetCoreForce.Client.Tests
{
    public class UriFormatterTest
    {
        const string _apiVersion = "v41.0";
        const string _instanceUrl = "https://xxx.salesforce.com";
        const string _sObjectName = "Account";
        const string _objectId = "001XXXXXXXXXXXXXXX";

        //Note: Uri.AbsoluteUri is fully escaped/URL encoded. UriToString() will leave some chars like spaces as is

        [Fact]
        public void SObjectRows()
        {
            string result = UriFormatter.SObjectRows("https://xxx.salesforce.com", "v41.0", "Account", "001XXXXXXXXXXXXXXX").AbsoluteUri;

            Assert.Equal("https://xxx.salesforce.com/services/data/v41.0/sobjects/Account/001XXXXXXXXXXXXXXX", result);
        }

        [Fact]
        public void SObjectRowsByExternalId()
        {
            string result = UriFormatter.SObjectRowsByExternalId(_instanceUrl, _apiVersion, _sObjectName, "externalfield", "externalvalue").AbsoluteUri;

            Assert.Equal("https://xxx.salesforce.com/services/data/v41.0/sobjects/Account/externalfield/externalvalue", result);
        }

        [Fact]
        public void SObjectBlobRetrieve()
        {
            string result = UriFormatter.SObjectBlobRetrieve(_instanceUrl, _apiVersion, _sObjectName, _objectId).AbsoluteUri;

            Assert.Equal("https://xxx.salesforce.com/services/data/v41.0/sobjects/Account/001XXXXXXXXXXXXXXX/body", result);
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
        public void SObjectTree()
        {
            string result = UriFormatter.SObjectTree("https://xxx.salesforce.com", "v41.0", "Account").AbsoluteUri;

            Assert.Equal("https://xxx.salesforce.com/services/data/v41.0/composite/tree/Account", result);
        }

        [Fact]
        public void SObjectBasicInformation()
        {
            string result = UriFormatter.SObjectBasicInformation("https://xxx.salesforce.com", "v41.0", "Account").AbsoluteUri;

            Assert.Equal("https://xxx.salesforce.com/services/data/v41.0/sobjects/Account", result);
        }

        [Fact]
        public void SObjectDescribe()
        {
            string result = UriFormatter.SObjectDescribe("https://xxx.salesforce.com", "v41.0", "Account").AbsoluteUri;

            Assert.Equal("https://xxx.salesforce.com/services/data/v41.0/sobjects/Account/describe", result);
        }

        [Fact]
        public void BaseUri()
        {
            string result = UriFormatter.BaseUri(_instanceUrl).AbsoluteUri;

            string expected = $"{_instanceUrl}/services/data/";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Versions()
        {
            string result = UriFormatter.Versions(_instanceUrl).AbsoluteUri;

            string expected = $"{_instanceUrl}/services/data";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void DescribeGlobal()
        {
            string result = UriFormatter.DescribeGlobal(_instanceUrl, _apiVersion).AbsoluteUri;

            string expected = $"{_instanceUrl}/services/data/{_apiVersion}/sobjects";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Limits()
        {
            string result = UriFormatter.Limits(_instanceUrl, _apiVersion).AbsoluteUri;

            string expected = $"{_instanceUrl}/services/data/{_apiVersion}/limits";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void LimitsResource()
        {
            Uri result = UriFormatter.LimitsResource(_apiVersion);

            Uri expected = new Uri($"{_apiVersion}/limits", UriKind.Relative);

            Assert.Equal(expected, result);
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

        [Fact]
        public void Search()
        {
            //TODO: add actual SOSL syntax
            string result = UriFormatter.Search( _instanceUrl, _apiVersion, "X Y").AbsoluteUri;

            Assert.Equal("https://xxx.salesforce.com/services/data/v41.0/search?q=X%20Y", result);
        }

        [Fact]
        public void Batch()
        {
            //TODO: add actual SOSL syntax
            string result = UriFormatter.Batch( _instanceUrl, _apiVersion).AbsoluteUri;

            Assert.Equal("https://xxx.salesforce.com/services/data/v41.0/composite/batch", result);
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
