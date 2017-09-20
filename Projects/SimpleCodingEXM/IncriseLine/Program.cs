using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncriseLine
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = int.Parse(Console.ReadLine());
            int prev = 0;
            int count =0;
            int max = 0;
            for (int i = 0; i < num; i++)
            {

                int tempNum = int.Parse(Console.ReadLine());

                if (tempNum==0 || tempNum > prev)
                {
                    count++;
                }
                else count = 1;
                if (count>max)
                {
                    max = count;
                }

                prev = tempNum;
            }
            Console.WriteLine(max);
        }
    }
}
