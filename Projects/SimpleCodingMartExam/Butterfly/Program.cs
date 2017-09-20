using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num-2; i++)
            {
                if (i%2==0)
                {
                    Console.Write(new string('-', num - 2));
                    Console.Write(@"\ /");
                    Console.Write(new string('-', num - 2));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(new string('*', num - 2));
                    Console.Write(@"\ /");
                    Console.Write(new string('*', num - 2));
                    Console.WriteLine();
                }
                

            }
            Console.Write(new string(' ',num-1));
            Console.WriteLine("@");

            for (int i = 1; i <= num - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(new string('-', num - 2));
                    Console.Write(@"/ \");
                    Console.Write(new string('-', num - 2));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(new string('*', num - 2));
                    Console.Write(@"/ \");
                    Console.Write(new string('*', num - 2));
                    Console.WriteLine();
                }


            }
        }
    }
}
