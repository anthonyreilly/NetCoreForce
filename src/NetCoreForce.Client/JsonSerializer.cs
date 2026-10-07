using System;
using System.Globalization;
using System.IO;
using System.Text;
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

            return Serialize(inputObject, formatting, new NullableContractResolver(fieldsToNull), ignoreNulls);
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
            return Serialize(inputObject, Formatting.None, new UpdateableContractResolver(fieldsToNull), ignoreNulls);
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
            return Serialize(inputObject, Formatting.None, new UpdateableWithIdContractResolver(fieldsToNull), ignoreNulls);
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
            return Serialize(inputObject, Formatting.None, new CreateableContractResolver(fieldsToNull), ignoreNulls);
        }

        /// <summary>
        /// Deserializes raw JSON into given type
        /// </summary>
        /// <param name="json">JSON object string</param>
        public static T Deserialize<T>(string json)
        {
            if (json == null) throw new ArgumentNullException(nameof(json));

            JsonSerializerSettings settings = CreateSettings();
            settings.CheckAdditionalContent = true;

            var serializer = Newtonsoft.Json.JsonSerializer.Create(settings);
            using (var reader = new JsonTextReader(new StringReader(json)))
            {
                return (T)serializer.Deserialize(reader, typeof(T));
            }
        }

        /// <summary>
        /// Settings used for all serialization and deserialization.
        /// <para>Applied with Newtonsoft.Json.JsonSerializer.Create, which - unlike JsonConvert - does not apply the host application's
        /// global JsonConvert.DefaultSettings. e.g. a host using TypeNameHandling.Auto would otherwise allow "$type" in a response to instantiate arbitrary types.</para>
        /// </summary>
        private static JsonSerializerSettings CreateSettings()
        {
            return new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.None,
                MaxDepth = 64,
                DateParseHandling = DateParseHandling.DateTime
            };
        }

        private static string Serialize(object inputObject, Formatting formatting, Newtonsoft.Json.Serialization.IContractResolver contractResolver, bool ignoreNulls)
        {
            JsonSerializerSettings settings = CreateSettings();
            settings.Formatting = formatting;
            settings.NullValueHandling = ignoreNulls ? NullValueHandling.Ignore : NullValueHandling.Include;
            settings.ContractResolver = contractResolver;
            settings.DateFormatString = DateFormats.FullDateFormatString;

            var serializer = Newtonsoft.Json.JsonSerializer.Create(settings);
            var stringWriter = new StringWriter(new StringBuilder(256), CultureInfo.InvariantCulture);
            using (var jsonWriter = new JsonTextWriter(stringWriter))
            {
                jsonWriter.Formatting = formatting;
                serializer.Serialize(jsonWriter, inputObject);
            }

            return stringWriter.ToString();
        }
    }
}
