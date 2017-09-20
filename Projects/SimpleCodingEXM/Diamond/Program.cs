using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int tempNum = num - 2;
            

            for (int topSide = 1; topSide <= num; topSide++)
            {
                Console.Write(new String(' ',num-topSide));
                Console.Write("*");
                for (int i = 0; i < topSide-1; i++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }

            for (int botSide = 1; botSide < num; botSide++)
            {
                Console.Write(new String(' ',botSide));
                Console.Write("*");
                for (int i = 0; i < tempNum; i++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
                tempNum--;
            }
        }
    }
}
