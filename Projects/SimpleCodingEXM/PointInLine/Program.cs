using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInLine
{
    class Program
    {
        static void Main(string[] args)
        {


            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());
            first = Math.Min(first, second);
            second = Math.Max(first, second);
            

            if (point>=first && point<=second)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }

            int firstDist = Math.Abs( first - point);
            int secondDist =Math.Abs( second - point);

            if (firstDist>secondDist)
            {
                Console.WriteLine(secondDist);

            }
            else
            {
                Console.WriteLine(firstDist); 
            }

        }
    }
}
