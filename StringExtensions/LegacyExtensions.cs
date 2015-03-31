using System;

namespace StringExtensions
{
    public static class LegacyExtensions
    {
        public static string ToLegacyFormat(this DateTime datetime)
        {
            return datetime.Year > 1930 ? datetime.ToString("1yyMMdd") :
                datetime.ToString("oyyMMdd");
           
        }
    }
}
