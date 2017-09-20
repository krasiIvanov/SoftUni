using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisions
{
    class Program
    {
        static void Main(string[] args)
        {

            string city = Console.ReadLine().ToLower();
            double sells = double.Parse(Console.ReadLine());

            double bonus = 0;

            if (city.Equals("sofia"))
            {
                if (sells>=0 && sells <= 500) bonus = 5;
                else if (sells > 500 && sells <= 1000) bonus = 7;
                else if (sells > 1000 && sells <= 10000) bonus = 8;
                else if (sells > 10000) bonus = 12;
            }
            else if (city.Equals("varna"))
            {
                 if (sells >= 0 && sells <= 500) bonus = 4.5;
                    else if (sells > 500 && sells <= 1000) bonus = 7.5;
                    else if (sells > 1000 && sells <= 10000) bonus = 10;
                    else if (sells > 10000) bonus = 13;
                
            }
            else if (city.Equals("plovdiv"))
            {
                if (sells >= 0 && sells <= 500) bonus = 5.5;
                else if (sells > 500 && sells <= 1000) bonus = 8;
                else if (sells > 1000 && sells <= 10000) bonus = 12;
                else if (sells > 10000) bonus = 14.5;

            }

            if (sells>=0)
            {
                Console.WriteLine("{0:f2}",(sells*bonus)/100);
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
