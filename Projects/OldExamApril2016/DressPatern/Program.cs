using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressPatern
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = int.Parse(Console.ReadLine());

            int downLine = 4*num;
            int star = 2 ;

            Console.Write(new string('_',downLine));
            Console.Write(".");            
            Console.Write(new string('_', downLine));
            Console.Write(".");
            Console.WriteLine(new string('_', downLine));
            downLine -= 2;
            for (int i = 0; i < num*2; i++)
            {
                Console.Write(new string('_',downLine));
                Console.Write(".");
                Console.Write(new string('*', star));
                Console.Write(".");
                Console.Write(new string('_', downLine));
                Console.Write(".");
                Console.Write(new string('*', star));
                Console.Write(".");
                Console.Write(new string('_', downLine));
                Console.WriteLine();
                downLine -= 2;
                star += 3;
            }
            for (int i = 0; i < num; i++)
            {
                Console.Write(".");
                Console.Write(new string('*',12*num));
                Console.Write(".");
                Console.WriteLine();
            }
            Console.Write(new string('.',num*3));
            Console.Write(new string('*', num *6 +2));
            Console.Write(new string('.', num * 3));
            Console.WriteLine();

            for (int i = 0; i < num; i++)
            {
                Console.Write(new string('_', num * 3));
                Console.Write(new string('o', num * 6 + 2));
                Console.Write(new string('_', num * 3));
                Console.WriteLine();
            }
            star = num * 6;
            for (int i = 0; i < num*3; i++)
            {
                Console.Write(new string('_', num * 3-i));
                Console.Write(".");
                Console.Write(new string('*', star));
                Console.Write(".");
                Console.Write(new string('_', num * 3 - i));
                Console.WriteLine();
                star += 2;
            }
            Console.WriteLine(new string('.',12*num+2));
        }
    }
}
