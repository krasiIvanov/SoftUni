using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace DateModifier
{
    public  class DataModifierClass
    {
        private double diff;

        public DataModifierClass()
        {

        }

       public  void GetDifference(string startDate,string endDate)
        {
            int[] startDateTokens = startDate.Split(' ').Select(int.Parse).ToArray();
            int[] endDateTokens = endDate.Split(' ').Select(int.Parse).ToArray();
            DateTime firstDate = new DateTime(startDateTokens[0], startDateTokens[1], startDateTokens[2]);
            DateTime secondDate = new DateTime(endDateTokens[0], endDateTokens[1], endDateTokens[2]);

            diff = (secondDate - firstDate).TotalDays;

            Console.WriteLine(Math.Abs(diff));
        }
    }
}
