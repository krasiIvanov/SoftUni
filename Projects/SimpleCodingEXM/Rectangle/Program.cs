using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int num = int.Parse(Console.ReadLine());
            double space = Math.Ceiling((double)num/2 - 1);


            Console.WriteLine(new String('%', num * 2));

            for (int i = 0; i < space; i++)
            {
                Console.Write("%");
                Console.Write(new String(' ', (2 * num) - 2));
                Console.Write("%");
                Console.WriteLine();
            }
            Console.Write("%");
            Console.Write(new String(' ',num-2));
            Console.Write("**");
            Console.Write(new String(' ', num - 2));
            Console.WriteLine("%");
            for (int i = 0; i < space; i++)
            {
                Console.Write("%");
                Console.Write(new String(' ', (2 * num) - 2));
                Console.Write("%");
                Console.WriteLine();
            }
            Console.WriteLine(new String('%', num * 2));

        }
    }
}
