using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    class DateModifier
    {
        public static void DiiffBetweenDates(string startDate,string endDate)
        {

            string[] startDateInfo = startDate.Split();
            DateTime startDt = DateTime.ParseExact($"{startDateInfo[0]}/{startDateInfo[1]}/{startDateInfo[2]}","yyyy/MM/dd",CultureInfo.CurrentCulture);
            
            string[] endDateInfo = endDate.Split();
            DateTime endDt = DateTime.ParseExact($"{endDateInfo[0]}/{endDateInfo[1]}/{endDateInfo[2]}", "yyyy/MM/dd", CultureInfo.CurrentCulture);

            var totalDays = Math.Abs((endDt - startDt).TotalDays);

            Console.WriteLine(totalDays);
        }
    }
}
