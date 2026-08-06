using System;
using System.Collections.Generic;
using Xunit;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;

namespace NetCoreForce.Client.Tests
{
    public class SObjectUriTests
    {
        const string ApiVersion = "v57.0";
        const string SObjectName = "Account";
        const string ObjectId = "001XXXXXXXXXXXXXXX";

        [Fact]
        public void SObjectRows()
        {
            string uriString = "/services/data/v57.0/sobjects/Account/001XXXXXXXXXXXXXXX";
            SObjectUri soi = new SObjectUri(uriString);

            Assert.Equal(uriString, soi.UriString);
            Assert.Equal(uriString, soi.ToString());
            Assert.Equal(ApiVersion, soi.ApiVersion);
            Assert.Equal(SObjectName, soi.SObjectName);
            Assert.Equal(ObjectId, soi.SObjectId);
        }

        [Fact]
        public void MalformedUri_TooFewSegments_ResultsInEmptyProperties()
        {
            // regex requires 3 path segments after "/services/data/" - this only has 1
            string uriString = "/services/data/v57.0";
            SObjectUri soi = new SObjectUri(uriString);

            Assert.Equal(uriString, soi.UriString);
            Assert.Equal(string.Empty, soi.ApiVersion);
            Assert.Equal(string.Empty, soi.SObjectName);
            Assert.Equal(string.Empty, soi.SObjectId);
        }

        [Fact]
        public void EmptyUri_ResultsInEmptyProperties()
        {
            SObjectUri soi = new SObjectUri(string.Empty);

            Assert.Equal(string.Empty, soi.UriString);
            Assert.Equal(string.Empty, soi.ApiVersion);
            Assert.Equal(string.Empty, soi.SObjectName);
            Assert.Equal(string.Empty, soi.SObjectId);
        }
    }
}
