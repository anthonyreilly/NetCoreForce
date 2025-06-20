using System;

namespace NetCoreForce.Client
{
    //https://developer.salesforce.com/docs/atlas.en-us.soql_sosl.meta/soql_sosl/sforce_api_calls_soql_select_dateformats.htm
    
    /// <summary>
    /// Provides Salesforce date format strings and methods for converting dates to those formats.
    /// </summary>
    public static class DateFormats
    {
        const string _FullFormat = "yyyy-MM-ddTHH:mm:sszzz";
        const string _FullFormatZulu = "yyyy-MM-ddTHH:mm:ssZ";
        const string _DateOnlyFormat = "yyyy-MM-dd";

        /// <summary>
        /// Date, time, and time zone offset
        /// </summary>
        /// <remarks>
        /// Uses the format "yyyy-MM-ddTHH:mm:sszzz" to output a date string e.g. "2023-10-01T12:34:56-07:00"
        /// </remarks>
        /// <returns>
        /// A string representing the full date format used by Salesforce.
        /// </returns>        
        public static string FullDateFormatString
        {
            get
            {
                return _FullFormat;
            }
        }

        /// <summary>
        /// Date only
        /// </summary>
        public static string DateOnlyFormatString
        {
            get
            {
                return _DateOnlyFormat;
            }
        }

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
            return dt.ToString(_FullFormat);
        }

        public static string FullDateString(DateTime dt, TimeSpan offset)
        {
            DateTimeOffset dto = new DateTimeOffset(dt, offset);
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