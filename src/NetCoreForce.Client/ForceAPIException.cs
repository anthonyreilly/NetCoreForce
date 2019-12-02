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

        /// <summary>
        /// Returned when an external ID exists in more than one record
        /// Lists matching objects in object url format, e.g. "/services/data/v44.0/sobjects/Account/001XXXXXXXXXXXXXXX"
        /// </summary>
        public List<string> ObjectUrls { get; set; }

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
    }
}
