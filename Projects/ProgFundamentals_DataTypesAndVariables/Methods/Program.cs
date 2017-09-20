using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int index= int.Parse(Console.ReadLine());

            Console.WriteLine(IntToBase(number,index));

        }
        public static string IntToBase(int number,int toBase)
        {
            string result = "";
            int num = 0;
            while (number!=0)
            {
                num = number % toBase;
                number /= toBase;
                result = num+result;
            }
            return result;
        }
    }
}
