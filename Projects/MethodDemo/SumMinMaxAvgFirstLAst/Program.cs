using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMinMaxAvgFirstLAst
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = int.Parse(Console.ReadLine());
            int[] numbers = new int[num];
            int first = 0;
            int last = 0;
            double sum = 0;
            

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i]= int.Parse(Console.ReadLine());
                if (i==0)
                {
                    first = numbers[i];
                }
                else if (i==num-1)
                {
                    last = numbers[i];
                }
                sum += numbers[i];
                
            }
            double avg = sum / num;
            Array.Sort(numbers);
            int min = numbers[0];
            int max = numbers[num - 1];

            Console.WriteLine("Sum = {0}\nMin = {1}\nMax = {2}\nFirst = {3}\nLast = {4}\nAverage = {5:0.0#} ",sum,min,max,first,last,avg);
        }
    }
}

