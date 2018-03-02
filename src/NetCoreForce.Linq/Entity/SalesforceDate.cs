using System;

namespace NetCoreForce.Linq.Entity
{
    public struct SalesforceDate
    {
        public SalesforceDate(DateTime time)
        {
            this.year = time.Year;
            this.month = time.Month;
            this.day = time.Day;
        }
        public SalesforceDate(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        private int year;
        public int Year { get { return year; } }
        private int month;
        public int Month { get { return month; } }
        private int day;
        public int Day { get { return day; } }
        public static SalesforceDate Now
        {
            get
            {
                return new SalesforceDate(DateTime.Now);
            }
        }

        public static bool operator ==(DateTime? d1, SalesforceDate d2)
        {
            return false;
        }
        public static bool operator !=(DateTime? d1, SalesforceDate d2)
        {
            return false;
        }
        public static bool operator >=(DateTime? d1, SalesforceDate d2)
        {
            return false;
        }
        public static bool operator <=(DateTime? d1, SalesforceDate d2)
        {
            return false;
        }
        public static bool operator >(DateTime d1, SalesforceDate d2)
        {
            return false;
        }
        public static bool operator <(DateTime d1, SalesforceDate d2)
        {
            return false;
        }
        public static bool operator ==(DateTime d1, SalesforceDate d2)
        {
            return false;
        }
        public static bool operator !=(DateTime d1, SalesforceDate d2)
        {
            return false;
        }
        public static bool operator >=(DateTime d1, SalesforceDate d2)
        {
            return false;
        }
        public static bool operator <=(DateTime d1, SalesforceDate d2)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}", Year, Month.ToString().PadLeft(2, '0'), Day.ToString().PadLeft(2, '0'));
        }
        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, Day);
        }
    }
}
