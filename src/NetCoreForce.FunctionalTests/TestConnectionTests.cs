using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;
using Newtonsoft.Json;
using System.Diagnostics;

namespace NetCoreForce.FunctionalTests
{
    public class TestConnectionTests : IClassFixture<ForceClientFixture>
    {
        ForceClientFixture forceClientFixture;

        public TestConnectionTests(ForceClientFixture fixture)
        {
            this.forceClientFixture = fixture;
        }

        [Fact]
        public void TestConnectionBadUrl()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;
            ForceClient client = new ForceClient(authInfo);

            Assert.False(client.TestConnection("https://badurl"));
            Assert.False(client.TestConnection("malformedurl"));
        }

        [Fact]
        public void TestConnection()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;
            ForceClient client = new ForceClient(authInfo);

            Stopwatch sw = new Stopwatch();
            Assert.True(client.TestConnection());
            sw.Stop();
            Console.WriteLine($"TestConnection() took {sw.ElapsedMilliseconds.ToString()}ms");
        }

        [Fact]
        public void TestConnectionToNa1()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;
            ForceClient client = new ForceClient(authInfo);

            //Barring any major server reorg in Salesforce, the NA1 production instance should always be there.
            //If this test fails, verify that the NA1 instance still exists.
            Assert.True(client.TestConnection("https://na1.salesforce.com"));
        }        
    }
}