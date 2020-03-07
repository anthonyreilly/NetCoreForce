using System;

namespace NetCoreForce.Client
{
    //https://developer.salesforce.com/docs/atlas.en-us.soql_sosl.meta/soql_sosl/sforce_api_calls_soql_select_dateformats.htm
    
    /// <summary>
    /// Salesforce date format strings
    /// </summary>
    public static class DateFormats
    {
        private const string _FullFormat = "yyyy-MM-ddTHH:mm:sszzz";
        private const string _FullFormatZulu = "yyyy-MM-ddTHH:mm:ssZ";
        private const string _DateOnlyFormat = "yyyy-MM-dd";

        /// <summary>
        /// Date, time, and time zone offset
        /// </summary>
        public static string FullDateFormatString => _FullFormat;

        /// <summary>
        /// Date only
        /// </summary>
        public static string DateOnlyFormatString => _DateOnlyFormat;

        public static string FullDateString(DateTimeOffset dto)
        {
            return dto.ToString(_FullFormat);
        }

        /// <summary>
        /// Converts the given DateTime to a SFDC compatible string.
        /// Result includes a time zone offset.
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string FullDateString(DateTime dt)
        {
            return dt.ToUniversalTime().ToString(_FullFormat);
        }

        public static string FullDateString(DateTime dt, TimeSpan offset)
        {
            var dto = new DateTimeOffset(dt, offset);
            return dto.ToString(_FullFormat);
        }

        public static string DateOnlyString(DateTimeOffset dto)
        {
            return dto.ToString(_DateOnlyFormat);
        }

        public static string DateOnlyString(DateTime dt)
        {
            return dt.ToString(_DateOnlyFormat);
        }
    }
}