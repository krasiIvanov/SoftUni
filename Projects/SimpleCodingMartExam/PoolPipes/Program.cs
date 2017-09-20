using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {


            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            
            double totalP1 = p1 * h;
            double totalP2 = p2 * h;
            double totalPipes = totalP1 + totalP2;
            int procents = (int)(totalPipes * 100) / v;
            int p1Procents = (int)((totalP1 * 100) / totalPipes);
            int p2Procents = (int)((totalP2 * 100) / totalPipes);

            if (totalPipes>v)
            {
                double overflow = totalPipes - v;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",h,overflow);

            }
            else
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",procents,p1Procents,p2Procents);
            }


        }
    }
}
