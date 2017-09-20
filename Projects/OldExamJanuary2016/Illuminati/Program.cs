using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Illuminati
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = int.Parse(Console.ReadLine());
            int dots = num-2;

            Console.Write(new string('.',num));
            Console.Write(new string('#', num));
            Console.Write(new string('.', num));
            Console.WriteLine();
            int insideDots = 0;
            for (int i = 0; i < num/2; i++)
            {
                insideDots = i * 2;
                Console.Write(new string('.',dots-i*2));
                Console.Write("##");
                Console.Write(new string('.', i*2));
                Console.Write("#");
                Console.Write(new string('.',num-2));
                Console.Write("#");
                Console.Write(new string('.', i * 2));
                Console.Write("##");
                Console.Write(new string('.', dots - i * 2));
                
                Console.WriteLine();

            }
            
            dots = 1;
            for (int i = 0; i < num / 2; i++)
            {
                Console.Write(new string('.', dots + i * 2));
                Console.Write("##");
                Console.Write(new string('.',insideDots-i*2));
                Console.Write("#");
                Console.Write(new string('.', num - 2));
                Console.Write("#");
                Console.Write(new string('.', insideDots - i * 2));
                Console.Write("##");
                Console.Write(new string('.', dots + i * 2));
                Console.WriteLine();


            }
            Console.Write(new string('.', num));
            Console.Write(new string('#', num));
            Console.Write(new string('.', num));
            Console.WriteLine();
        }
    }
}
