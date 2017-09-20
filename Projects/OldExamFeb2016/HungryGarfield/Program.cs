using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryGarfield
{
    class Program
    {
        static void Main(string[] args)
        {


            decimal money = decimal.Parse(Console.ReadLine());
            decimal dolarRate = decimal.Parse(Console.ReadLine());
            decimal pizzaPrice = decimal.Parse(Console.ReadLine());
            decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
            decimal sandwichPrice = decimal.Parse(Console.ReadLine());
            uint pizzaQuantity = uint.Parse(Console.ReadLine());
            uint lasagnaQuantity = uint.Parse(Console.ReadLine());
            uint sandwichQuantity = uint.Parse(Console.ReadLine());

            decimal pizzaSum = (pizzaPrice / dolarRate) * pizzaQuantity;
            decimal lasgnaSum = (lasagnaPrice / dolarRate) * lasagnaQuantity;
            decimal sandwichSum = (sandwichPrice / dolarRate) * sandwichQuantity;
            decimal totalSum = pizzaSum + lasgnaSum + sandwichSum;
            decimal needMoney = totalSum - money;
            decimal moneyLeft = money - totalSum;
            if (money>=totalSum)
            {
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", moneyLeft);
            }
            else
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", needMoney);
            }
            


        }
    }
}
