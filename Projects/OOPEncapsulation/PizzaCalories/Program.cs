using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pizzaTokens = Console.ReadLine().Split(' ');
            string[] doughTokens = Console.ReadLine().Split(' ');

            try
            {
                Dough dough = new Dough(doughTokens[1].ToLower(), doughTokens[2].ToLower(), double.Parse(doughTokens[3]));
                Pizza pizza = new Pizza(pizzaTokens[1], int.Parse(pizzaTokens[2]), dough);
                

                string input = Console.ReadLine();
                while (input != "END")
                {
                    string[] toppingsTokens = input.Split(' ');

                    Topping topping = new Topping(toppingsTokens[1].ToLower(), double.Parse(toppingsTokens[2]));
                    pizza.addTopping(topping);

                    input = Console.ReadLine();
                }
                Console.WriteLine(pizza);

            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
                
            }

            

        }
    }
}
