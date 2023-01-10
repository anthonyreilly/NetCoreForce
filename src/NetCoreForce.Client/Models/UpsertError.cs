using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public class UpsertError
    {
        [JsonProperty(PropertyName = "statusCode")]
        public string StatusCode { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        [JsonProperty(PropertyName = "fields")]
        public List<string> Fields { get; set; }
    }
}
