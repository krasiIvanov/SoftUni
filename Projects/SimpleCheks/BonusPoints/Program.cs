using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            double num = double.Parse(Console.ReadLine());
            double bonus = 0;
            double moreBonus = 0;

            if (num<=100)
            {
                bonus = 5;
            }
            else if(num>100 && num<=1000 )
            {
                bonus = (num * 20) / 100;
            }
            else if(num>1000)
            {
                bonus = (num * 10) / 100;
            }
            if (num%2==0)
            {
                moreBonus = 1;
            }
            else if (num % 10 == 5)
            {
                moreBonus = 2;
            }

            double finalBonus = bonus + moreBonus;

            Console.WriteLine("Bonus score: {0}",finalBonus);
            Console.WriteLine("Final score: {0}",(num+finalBonus));
        }
    }
}
