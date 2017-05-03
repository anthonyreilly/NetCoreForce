using System;
using System.Net;
//using NetCoreForce.Client.Models;

namespace NetCoreForce.Client
{
    public class ForceAuthException : Exception
    {
        public string ErrorCode { get; private set; }
        public HttpStatusCode HttpStatusCode { get; private set; }

        public ForceAuthException(string errorCode, string message)
            : this (errorCode, message, new HttpStatusCode())
        {
        }

        public ForceAuthException(string errorCode, string message, HttpStatusCode httpStatusCode)
            : base(message)
        {
            ErrorCode = errorCode;
            HttpStatusCode = httpStatusCode;
        }

        // private static Error ParseError(string error)
        // {
        //     Error value;
        //     return Enum.TryParse(error.Replace("_", ""), true, out value) ? value : Error.Unknown;
        // }
    }
}
