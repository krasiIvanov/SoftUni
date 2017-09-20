using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int secSum = num1 + num2 + num3;
            int min = secSum / 60;
            int secLeft = min * 60 - secSum;

            if (secSum<60)
            {
                Console.WriteLine("0:{0:D2}",secSum);
            }
            else if (secSum>=60&&secSum<120)
            {
                Console.WriteLine("1:{0:.D2}",(secSum-60));
            }
            else if (secSum>=120&&secSum<180)
            {
                Console.WriteLine("2:{0:D2}",(secSum-120));
            }
           


        }
    }
}
