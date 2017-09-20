using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = int.Parse(Console.ReadLine());

            threeOnRow(num);
        }

        private static void threeOnRow(int num)
        {
            for (char i = 'a'; i < 'a' + num; i++)
            {
                for (char j = 'a'; j < 'a' + num; j++)
                {
                    for (char n = 'a'; n < 'a' + num; n++)
                    {

                        Console.Write((char)i);
                        Console.Write((char)j);
                        Console.Write((char)n + " ");


                    }
                }
            }
        }
    }
}
