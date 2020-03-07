using System;
using System.Net;

namespace NetCoreForce.Client
{
    /// <summary>
    /// Very basic implementation of IWebProxy
    /// </summary>
    public class CustomProxy : IWebProxy
    {
        private readonly Uri _proxyUri;

        public CustomProxy(string proxyUrl) => _proxyUri = new Uri(proxyUrl);

        public CustomProxy(Uri proxyUri) => _proxyUri = proxyUri;

        public ICredentials Credentials { get; set; }

        public bool IsBypassed(Uri host) => false;

        public Uri GetProxy(Uri destination) => _proxyUri;
    }
}