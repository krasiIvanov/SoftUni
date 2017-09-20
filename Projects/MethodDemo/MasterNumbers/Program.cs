using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (Polindorme(i) && (SumOfDigits(i) %7==0) && Even(i))
                {
                    Console.WriteLine(i);
                }
            }
            

        }

        public static bool Polindorme(int num)
        {
           
                string digits = num + "";
                for (int i = 0; i < digits.Length/2; i++)
                {
                    if (digits[i] != digits[digits.Length - i-1])
                    {
                        
                        return false;
                    }
                    
                }        
            return true;
        }//end polidrome

        public static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num>0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;          
        }//end SumOfDigits

        public static bool Even(int num)
        {
            string digits = num + "";
            for (int i = 0; i < digits.Length; i++)
            {
                if ((int)digits[i] %2==0)
                {
                    return true;
                }
            }
            return false;
        }// end Even

    }//end class


}
