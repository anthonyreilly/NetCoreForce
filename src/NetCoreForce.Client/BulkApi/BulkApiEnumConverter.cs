using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// Serializes Bulk API enums using their EnumMember values.
    /// <para>When deserializing to a nullable enum, values not defined in the enum are read as null rather than throwing.
    /// e.g. Get All Jobs also returns Bulk API (Classic) jobs, whose state and content type values differ from Bulk API 2.0.</para>
    /// </summary>
    internal class BulkApiEnumConverter : StringEnumConverter
    {
        public BulkApiEnumConverter()
        {
            AllowIntegerValues = false;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            try
            {
                return base.ReadJson(reader, objectType, existingValue, serializer);
            }
            catch (JsonSerializationException) when (Nullable.GetUnderlyingType(objectType) != null)
            {
                return null;
            }
        }
    }
}
