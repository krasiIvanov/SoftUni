using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualParts
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;

            int[] sums = new int[num];

            for (int i = 0; i < num; i++)
            {
                
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                sums[i] = num1 + num2;

            }
            for (int i = 0; i < sums.Length; i++)
            {
                if (sums[i] < min) min = sums[i];
            }
            for (int i = 0; i < sums.Length; i++)
            {
                if (sums[i] > max) max = sums[i];
            }
            if (max==min)
            {
                Console.WriteLine("Yes,value= {0}",max);
            }
            else
            {
                int diff = (max - min);
                Console.WriteLine("No,maxDiff= {0}", diff);
            }
        }
    }
}
