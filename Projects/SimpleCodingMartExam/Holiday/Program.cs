using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday
{
    class Program
    {
        static void Main(string[] args)
        {


            double num = double.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToLower();
            string place="";




            if (num <= 100)
            {
                place = "Bulgaria";
                if (type.Equals("summer"))
                {
                    double procent = (num / 100) * 30;
                    procent = Math.Round(procent, 2);
                    Console.WriteLine("Somewhere in {0}", place);
                    Console.WriteLine("Camp - {0:0.00}", procent);

                }
                else if (type.Equals("winter"))
                {
                    double procent = (num / 100) * 70;
                    procent = Math.Round(procent, 2);
                    Console.WriteLine("Somewhere in {0}", place);
                    Console.WriteLine("Hotel - {0:0.00}", procent);
                }
            }
            else if (num > 100 && num <= 1000)
            {
                place = "Balkans";
                if (type.Equals("summer"))
                {
                    double procent = (num / 100) * 40;
                    procent = Math.Round(procent, 2);
                    Console.WriteLine("Somewhere in {0}", place);
                    Console.WriteLine("Camp - {0:0.00}", procent);
                }
                else if (type.Equals("winter"))
                {
                    double procent = (num / 100) * 80;
                    procent = Math.Round(procent, 2);
                    Console.WriteLine("Somewhere in {0}", place);
                    Console.WriteLine("Hotel - {0:0.00}", procent);
                }
            }
            else
            {
                place = "Europe";
                
                    double procent = (num / 100) * 90;
                    procent = Math.Round(procent, 2);
                    Console.WriteLine("Somewhere in {0}", place);
                    Console.WriteLine("Hotel - {0:0.00}", procent);
                
            }

        }
    }
}
