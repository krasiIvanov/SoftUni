using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < num; i++)
            {
                int tempNum= int.Parse(Console.ReadLine());
                if (tempNum<200)
                {
                    p1++;
                }
                else if (tempNum>=200 && tempNum<400)
                {
                    p2++;
                }
                else if (tempNum>=400 && tempNum<600)
                {
                    p3++;
                }
                else if (tempNum >= 600 && tempNum < 800)
                {
                    p4++;
                }
                else if (tempNum>=800)
                {
                    p5++;
                }
            }
            p1 = Math.Round((p1 / num) * 100,2);
            p2 = Math.Round((p2 / num) * 100, 2);
            p3 = Math.Round((p3 / num) * 100, 2);
            p4 = Math.Round((p4 / num) * 100, 2);
            p5 = Math.Round((p5 / num) * 100, 2);

            Console.WriteLine("{0:0.00}%", p1);
            Console.WriteLine("{0:0.00}%", p2);
            Console.WriteLine("{0:0.00}%", p3);
            Console.WriteLine("{0:0.00}%", p4);
            Console.WriteLine("{0:0.00}%", p5);
        }
    }
}
