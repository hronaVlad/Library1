using System;
using System.Collections.Generic;
using System.Text;

namespace Library1
{
    public class DateUtil
    {
        public static DateTime GetCurrent() => DateTime.Now;

        public static DateTime? ParseToLocalTime(string data)
        {
            if (DateTime.TryParse(data, out var dt))
            {
                return dt.ToLocalTime();
            };

            return null;
        }
    }
}
