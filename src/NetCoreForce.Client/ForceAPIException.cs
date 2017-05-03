using System;
using System.Collections.Generic;
using System.Net;
using NetCoreForce.Client.Models;

namespace NetCoreForce.Client
{
    public class ForceApiException : Exception
    {
        public List<ErrorResponse> Errors { get; set; }

        // public string[] Fields { get; private set; }
        // public string ErrorCode { get; private set; }
        public HttpStatusCode HttpStatusCode { get; private set; }

        public ForceApiException(string message)
            : this(message, new List<ErrorResponse>(), new HttpStatusCode())
        {
        }

        public ForceApiException(string message, List<ErrorResponse> errors)
            : this(message, errors, new HttpStatusCode())
        {
        }

        public ForceApiException(string message, ErrorResponse error, HttpStatusCode httpStatusCode)
            : this(message, new List<ErrorResponse>() { error }, new HttpStatusCode())
        {
        }

        public ForceApiException(string message, List<ErrorResponse> errors, HttpStatusCode httpStatusCode)
            : base(message)
        {
            Errors = errors;
            HttpStatusCode = httpStatusCode;
        }

        // public ForceApiException(List<ErrorResponse> errors, HttpStatusCode httpStatusCode)
        //     : base()
        // {
        //     Errors = errors;
        //     HttpStatusCode = httpStatusCode;
        // }

        // private static Error ParseError(string error)
        // {
        //     Error value;
        //     return Enum.TryParse(error.Replace("_", ""), true, out value) ? value : Error.Unknown;
        // }
    }
}
