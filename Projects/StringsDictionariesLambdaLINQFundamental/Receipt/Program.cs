using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receipt
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Console.WriteLine("/"+new string('-',22)+@"\");
            foreach (var item in nums)
            {
                Console.WriteLine("| {0,20:f2} |",item);
            }
            Console.WriteLine("|"+new string('-',22)+"|");
            Console.WriteLine("| Total:{0,14:f2} |",nums.Sum());
            Console.WriteLine("\\" + new string('-', 22) + "/");

        }
    }
}
