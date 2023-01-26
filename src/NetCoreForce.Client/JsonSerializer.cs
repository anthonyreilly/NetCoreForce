using System;
using Newtonsoft.Json;
using NetCoreForce.Client.Serializer;
using System.Collections.Generic;

namespace NetCoreForce.Client
{
    public static class JsonSerializer
    {
        /// <summary>
        /// Serializes an object into JSON including all non-null properties.
        /// <para>Not to be used for create and update calls</para>
        /// </summary>
        /// <param name="inputObject">Object to serialize</param>
        /// <param name="indented">use indented formatting, usually for readability</param>
        /// <param name="fieldsToNull">A list of properties that should be set to null, but inclusing the null values in the serialized output</param>
        /// <param name="ignoreNulls">Use with caution. By default null values are not serialized, this will serialize all explicitly nulled or missing properties as null</param>  
        /// <returns>JSON string</returns>
        public static string SerializeComplete(object inputObject, bool indented, List<string> fieldsToNull = null, bool ignoreNulls = true)
        {
            Formatting formatting = Formatting.None;
            if(indented)
            {
                formatting = Formatting.Indented;
            }

            string serializedJson = JsonConvert.SerializeObject(inputObject,
                   formatting,
                   new JsonSerializerSettings
                   {
                       NullValueHandling = ignoreNulls ? NullValueHandling.Ignore : NullValueHandling.Include,
                       ContractResolver = new NullableContractResolver(fieldsToNull),
                       DateFormatString = DateFormats.FullDateFormatString
                   });

            return serializedJson;
        }

        /// <summary>
        /// Serializes an object into JSON for SObject updates, using the UpdateableContractResolver
        /// </summary>
        /// <param name="inputObject">Object to serialize</param>
        /// <param name="fieldsToNull">A list of properties that should be set to null, but inclusing the null values in the serialized output</param>
        /// <param name="ignoreNulls">Use with caution. By default null values are not serialized, this will serialize all explicitly nulled or missing properties as null</param>        
        /// <returns></returns>
        public static string SerializeForUpdate(object inputObject, List<string> fieldsToNull = null, bool ignoreNulls = true)
        {
            string serializedJson = JsonConvert.SerializeObject(inputObject,
                   Formatting.None,
                   new JsonSerializerSettings
                   {
                       NullValueHandling = ignoreNulls ? NullValueHandling.Ignore : NullValueHandling.Include,
                       ContractResolver = new UpdateableContractResolver(fieldsToNull),
                       DateFormatString = DateFormats.FullDateFormatString
                   });

            return serializedJson;
        }

        /// <summary>
        /// Serializes an object into JSON for SObject updates, using the UpdateableContractResolver.
        /// Includes the SObject ID for calls that require it
        /// </summary>
        /// <param name="inputObject">Object to serialize</param>
        /// <param name="fieldsToNull">A list of properties that should be set to null, but inclusing the null values in the serialized output</param>
        /// <param name="ignoreNulls">Use with caution. By default null values are not serialized, this will serialize all explicitly nulled or missing properties as null</param>  
        /// <returns>JSON string, unformatted</returns>
        public static string SerializeForUpdateWithObjectId(object inputObject, List<string> fieldsToNull = null, bool ignoreNulls = true)
        {
            string serializedJson = JsonConvert.SerializeObject(inputObject,
                   Formatting.None,
                   new JsonSerializerSettings
                   {
                       NullValueHandling = ignoreNulls ? NullValueHandling.Ignore : NullValueHandling.Include,
                       ContractResolver = new UpdateableWithIdContractResolver(fieldsToNull),
                       DateFormatString = DateFormats.FullDateFormatString
                   });

            return serializedJson;
        }

        /// <summary>
        /// Serializes an object into JSON for SObject creation, using the CreateableContractResolver
        /// </summary>
        /// <param name="inputObject">Object to serialize</param>
        /// <param name="fieldsToNull">A list of properties that should be set to null, but inclusing the null values in the serialized output</param>
        /// <param name="ignoreNulls">Use with caution. By default null values are not serialized, this will serialize all explicitly nulled or missing properties as null</param>  
        /// <returns>JSON string, unformatted</returns>
        public static string SerializeForCreate(object inputObject, List<string> fieldsToNull = null, bool ignoreNulls = true)
        {
            string serializedJson = JsonConvert.SerializeObject(inputObject,
                   Formatting.None,
                   new JsonSerializerSettings
                   {
                       NullValueHandling = ignoreNulls ? NullValueHandling.Ignore : NullValueHandling.Include,
                       ContractResolver = new CreateableContractResolver(fieldsToNull),
                       DateFormatString = DateFormats.FullDateFormatString
                   });

            return serializedJson;
        }

        /// <summary>
        /// Deserializes raw JSON into given type
        /// </summary>
        /// <param name="json">JSON object string</param>
        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}