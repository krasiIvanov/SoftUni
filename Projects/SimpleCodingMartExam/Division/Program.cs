using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {


            double n = double.Parse(Console.ReadLine());
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;

            for (int i = 0; i < n; i++)
            {
                int tempNum= int.Parse(Console.ReadLine());
                if (tempNum % 2 == 0)
                {
                    num1++;
                }
                 if (tempNum % 3 == 0)
                {
                    num2++;
                }
                 if (tempNum%4==0)
                {
                    num3++;
                }

            }
            num1 = (num1 / n) * 100;
            num2 = (num2 / n) * 100;
            num3 = (num3 / n) * 100;

            Console.WriteLine("{0:0.00}%",num1);
            Console.WriteLine("{0:0.00}%", num2);
            Console.WriteLine("{0:0.00}%", num3);
        }
    }
}
