using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            double sum = (num1 + num2 + num3);

            TimeSpan result = TimeSpan.FromSeconds(sum);

            Console.WriteLine(result.ToString(@"m\:ss"));
        }
    }
}
