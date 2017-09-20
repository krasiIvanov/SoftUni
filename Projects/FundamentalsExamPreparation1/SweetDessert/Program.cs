using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {


            decimal money = decimal.Parse(Console.ReadLine());
            decimal guests = decimal.Parse(Console.ReadLine());
            decimal bannanasPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal barriers = decimal.Parse(Console.ReadLine());
            
            decimal neededDesert = Math.Ceiling(guests / 6);
            
            decimal isEnought = neededDesert * ((2m * bannanasPrice) + (4m * eggsPrice) + (0.2m * barriers));
            
            if (isEnought <= money)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", isEnought);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", isEnought - money);
            }
        }
    }
}
