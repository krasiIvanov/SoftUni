using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterHerbalist
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = int.Parse(Console.ReadLine());
            int days = 0;
            int totalSum = 0;
            while (true)
            {
                string comand = Console.ReadLine();
                if (comand== "Season Over")
                {
                    break;
                }
                else
                {
                    days++;
                }

                var comandArr = comand.Split(' ').ToArray();
                int hours = int.Parse(comandArr[0]);
                string herbs = comandArr[1];
                int price = int.Parse(comandArr[2]);
                int herbCount = 0;
                int start = herbs.Length;
                for (int i = 0; i < hours; i++)
                {
                    if (herbs[i % herbs.Length] == 'H')
                    {
                        herbCount++;
                    }
                }

                int sum = herbCount * price;
                
                
                totalSum += sum;
                
            }
            
            decimal avg = (decimal)totalSum / days;            
            decimal extra = Math.Abs(avg - num);
            int diff = num * days - totalSum;

            if (avg > num)
            {
                Console.WriteLine("Times are good. Extra money per day: {0:f2}.", extra);
            }
            else
            {
                Console.WriteLine("We are in the red. Money needed: {0}.", diff);
            }

        }
    }
}
