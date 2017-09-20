using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapec
{
    class Program
    {
        static void Main(string[] args)
        {

            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            double width = Math.Abs(x1 - x2);
            double height = Math.Abs(y1 - y2);
            Console.WriteLine("Area = {0}", width * height);
            Console.WriteLine("Perimeter = {0}", 2 * (width + height));


        }
    }
}
