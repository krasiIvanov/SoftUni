using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallenInlove
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = int.Parse(Console.ReadLine());
            int dots = num * 2;
            int insideDots = 0;

            for (int i = 0; i < num; i++)
            {

                Console.Write("#");
                Console.Write(new string('~', i));
                Console.Write("#");
                Console.Write(new string('.',dots));
                Console.Write("#");
                Console.Write(new string('.', insideDots));
                Console.Write("#");
                Console.Write(new string('.', dots));
                Console.Write("#");
                Console.Write(new string('~', i));
                Console.Write("#");
                Console.WriteLine();
                dots -= 2;
                insideDots += 2;
            }
            dots = 1;
            insideDots = num*2;
            for (int i = 0; i < num+1; i++)
            {
                Console.Write(new string('.',dots));
                Console.Write("#");
                Console.Write(new string('~',num-i));
                Console.Write("#");
                Console.Write(new string('.', insideDots));
                Console.Write("#");
                Console.Write(new string('~', num - i));
                Console.Write("#");
                Console.Write(new string('.', dots));
                Console.WriteLine();
                dots += 2;
                insideDots -= 2;

            }
            for (int i = 0; i < num; i++)
            {
                Console.Write(new string('.',num*2+2));
                Console.Write("##");
                Console.Write(new string('.', num*2+2));
                Console.WriteLine();
            }

        }
    }
}
