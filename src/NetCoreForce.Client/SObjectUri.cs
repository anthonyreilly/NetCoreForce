using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NetCoreForce.Client.Models;

namespace NetCoreForce.Client
{

    public class SObjectUri
    {
        public string UriString { get; private set; }
        public string ApiVersion { get; private set; }
        public string SObjectName { get; private set; }
        public string SObjectId { get; private set; }

        public SObjectUri() { }

        public SObjectUri(string uriString)
        {
            this.UriString = uriString;
            ParseUriString(uriString);
        }

        public override string ToString()
        {
            return this.UriString;
        }

        private void ParseUriString(string uriString)
        {
            Regex rx = new Regex(@"\/services\/data\/(.+)\/.+\/(.+)\/(.+)", RegexOptions.Compiled);
            var match = rx.Match(uriString);

            this.ApiVersion = match.Groups[1].Value;
            this.SObjectName = match.Groups[2].Value;
            this.SObjectId = match.Groups[3].Value;
        }

        /// <summary>
        /// SObject URI
        /// </summary>
        /// <param name="apiVersion">SFDC API version, e.g. "v48.0"</param>
        /// <param name="sObjectName">SObject name, e.g. "Account"</param>
        /// <param name="objectId">SObject ID</param>
        /// <returns></returns>
        private static string SObjectRows(string apiVersion, string sObjectName, string objectId)
        {
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException("apiVersion");
            if (string.IsNullOrEmpty(sObjectName)) throw new ArgumentNullException("sObjectName");
            if (string.IsNullOrEmpty(objectId)) throw new ArgumentNullException("objectId");

            // format: /vXX.X/sobjects/SObjectName/id/
            // example with field parameter: services/data/v20.0/sobjects/Account/001D000000INjVe 

            return string.Format("services/data/{0}/sobjects/{1}/{2}", apiVersion, sObjectName, objectId);
        }
    }
}