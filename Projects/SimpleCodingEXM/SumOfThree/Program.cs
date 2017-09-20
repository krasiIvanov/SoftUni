using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfThree
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3= int.Parse(Console.ReadLine());

            int[] numbers = new int[] {num,num2,num3 };
            Array.Sort(numbers);
            int min =numbers[0];
            int second = numbers[1];
            int max = numbers[2];
            if (min+second==max)
            {
                Console.WriteLine("{0} + {1} = {2}",min,second,max);
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
