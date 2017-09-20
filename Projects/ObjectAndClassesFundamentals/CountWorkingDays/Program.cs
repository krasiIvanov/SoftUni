using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {

           

            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            int count = 0;
            DateTime[] halidays = new DateTime[]
            {
                new DateTime(1,1,1),
                new DateTime(1,3,3),
                new DateTime(1,5,1),
                new DateTime(1,5,6),
                new DateTime(1,5,24),
                new DateTime(1,9,6),
                new DateTime(1,9,22),
                new DateTime(1,11,1),
                new DateTime(1,12,24),
                new DateTime(1,12,25),
                new DateTime(1,12,26)
            };

            for (DateTime date=startDate; date <= endDate; date=date.AddDays(1))
            {
                DateTime tempDate = new DateTime(1, date.Month, date.Day);
                bool isWeekDay = date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday;
                bool isHoliday = !halidays.Contains(tempDate);
                

                if (isWeekDay&&isHoliday)
                {
                    count++;
                }
            }

            Console.WriteLine(count);

        }
    }
}
