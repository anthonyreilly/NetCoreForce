using System;

namespace NetCoreForce.Client
{
    //https://developer.salesforce.com/docs/atlas.en-us.soql_sosl.meta/soql_sosl/sforce_api_calls_soql_select_dateformats.htm
    
    /// <summary>
    /// Salesforce date format strings
    /// </summary>
    public static class DateFormats
    {
        const string _FullFormat = "yyyy-MM-ddTHH:mm:sszzz";
        const string _DateOnlyFormat = "yyyy-MM-dd";

        /// <summary>
        /// Date, time, and time zone offset
        /// </summary>
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