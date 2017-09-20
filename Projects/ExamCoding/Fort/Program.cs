using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fort
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = int.Parse(Console.ReadLine());
            //x=8-(2+5/2)
            int downLine = (num * 2) - 4 - ((num / 2) * 2);



            Console.Write("/");
            Console.Write(new string('^', num / 2));
            Console.Write(@"\");
            if (downLine > 0)
            {
                Console.Write(new String('_', downLine));
            }

            Console.Write("/");
            Console.Write(new string('^', num / 2));
            Console.Write(@"\");
            Console.WriteLine();




            for (int j = 1; j <= num - 2; j++)
            {
                
                if (j==num-2)
                {
                    Console.Write("|");
                    Console.Write(new String(' ', num/2+1));
                    Console.Write(new String('_',downLine));
                    Console.Write(new String(' ', num / 2+1));
                    Console.Write("|");
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("|");
                    Console.Write(new String(' ', num * 2 - 2));
                    Console.Write("|");
                    Console.WriteLine();
                }
            }


            Console.Write(@"\");
            Console.Write(new string('_', num / 2));
            Console.Write("/");
            if (downLine > 0)
            {
                Console.Write(new String(' ', downLine));
            }

            Console.Write(@"\");
            Console.Write(new string('_', num / 2));
            Console.Write("/");
            Console.WriteLine();






        }
    }
}
