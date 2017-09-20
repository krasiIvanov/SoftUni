using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopForFood
{
    class Program
    {
        static void Main(string[] args)
        {

            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quant = double.Parse(Console.ReadLine());

            double price = -1.0;

            
             if (day.Equals("monday") || day.Equals("tuesday") || day.Equals("wendsday") || day.Equals("friday") || day.Equals("thursday"))
            {
                if (fruit.Equals("banana")) price = 2.50;
                else if (fruit.Equals("apple")) price = 1.20;
                else if (fruit.Equals("orange")) price = 0.85;
                else if (fruit.Equals("grapefrui")) price = 1.45;
                else if (fruit.Equals("kiwi")) price = 2.70;
                else if (fruit.Equals("pineapple")) price = 5.50;
                else if (fruit.Equals("grapes")) price = 3.85;
            }else if (day.Equals("saturday") || day.Equals("sunday"))
            {
                if (fruit.Equals("banana")) price = 2.70;
                else if (fruit.Equals("apple")) price = 1.25;
                else if (fruit.Equals("orange")) price = 0.90;
                else if (fruit.Equals("grapefrui")) price = 1.60;
                else if (fruit.Equals("kiwi")) price = 3.00;
                else if (fruit.Equals("pineapple")) price = 5.60;
                else if (fruit.Equals("grapes")) price = 4.20;
            }
            if (price >= 0)
            {
                Console.WriteLine("{0:f2}", price * quant);
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
