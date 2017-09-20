using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var num = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            //3 3 6 1
            for (int i = 0; i < num.Count-1; i++)
            {
                if (num[i] == num[i+1])
                {
                    num[i] *= 2;
                    num.RemoveAt(i + 1);
                    i-=2;
                    if (i<0)
                    {
                        i = -1;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",num));
        }
    }
}
