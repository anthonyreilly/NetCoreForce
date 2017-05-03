using System;
using System.Net;

namespace NetCoreForce.Client
{
    /// <summary>
    /// Very basic implementation of IWebProxy
    /// </summary>
    public class CustomProxy : IWebProxy
    {
        private Uri _proxyUri;

        public Uri GetProxy(Uri destination)
        {
            return _proxyUri;
        }
        public bool IsBypassed(Uri host)
        {
            return false;
        }
        public ICredentials Credentials { get; set; }

        public CustomProxy(string proxyUrl)
        {
            this._proxyUri = new Uri(proxyUrl);
        }

        public CustomProxy(Uri proxyUri)
        {
            this._proxyUri = proxyUri;
        }
    }
}