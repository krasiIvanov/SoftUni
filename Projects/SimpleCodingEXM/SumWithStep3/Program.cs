using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumWithStep3
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = int.Parse(Console.ReadLine());
            var numbers = new int[num];
            
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            for (int i = 0; i < num; i++)
            {
                numbers[i]= int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i+=3)
            {
                sum1 += numbers[i];
            }
            for (int i = 1; i < numbers.Length; i+=3)
            {
                sum2 += numbers[i];
            }
            for (int i = 2; i < numbers.Length; i += 3)
            {
                sum3 += numbers[i];
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("sum1 = "+sum1);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("sum2 = " + sum2);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("sum3 = " + sum3);
            Console.ResetColor();
        }
    }
}
