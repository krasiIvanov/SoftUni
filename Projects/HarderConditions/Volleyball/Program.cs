using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {

            string year = Console.ReadLine().ToLower();
            double holiday = double.Parse(Console.ReadLine());
            double homeTown = double.Parse(Console.ReadLine());

            double gameWeek = 0;
            double holiWeek = 0;
            double result = 0;

            if (year.Equals("leap"))
            {
                gameWeek = (48 - homeTown) * 3 / 4;
                holiWeek = holiday * 2 / 3;
                double leapYear= (gameWeek + holiWeek) * 0.15;
                result = Math.Floor( gameWeek + holiWeek+leapYear+homeTown);
                Console.WriteLine(result);
            }
            else if (year.Equals("normal"))
            {
                gameWeek = (48 - homeTown) * 3 / 4;
                holiWeek = holiday * 2 / 3;

                result = Math.Floor(gameWeek + holiWeek+homeTown);
                Console.WriteLine(result);
            }
            
        }
    }
}
