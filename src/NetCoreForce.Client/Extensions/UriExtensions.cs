using System;
using System.Web;

namespace NetCoreForce.Client.Extensions
{
    public static class UriExtensions
    {
        public static Uri AddQueryParameter(this Uri uri, string key, string value)
        {
            var uriBuilder = new UriBuilder(uri);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query[key] = value;
            uriBuilder.Query = query.ToString();
            return uriBuilder.Uri;
        }
    }
}
