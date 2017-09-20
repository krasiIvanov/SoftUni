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
            string name = pizzaTokens[1];
            int numberOfToppings = int.Parse(pizzaTokens[2]);

            try
            {
                Pizza pizza = new Pizza(name, numberOfToppings);

                string[] doughTokens = Console.ReadLine().Split(' ');

                string flourType = doughTokens[1];
                string bakingTechnique = doughTokens[2];
                double weight = double.Parse(doughTokens[3]);

                Dough dough = new Dough(flourType,bakingTechnique,weight);

                pizza.Dough = dough;

                for (int i = 0; i < numberOfToppings; i++)
                {
                    string[] toppingsTokens = Console.ReadLine().Split(' ');
                    string type = toppingsTokens[1];
                    double toppingsWeight = double.Parse(toppingsTokens[2]);
                    Topping topping = new Topping(type, toppingsWeight);
                    pizza.AddTopping(topping);
                }

                string end = Console.ReadLine();
                Console.WriteLine($"{pizza.Name} - {pizza.GetTotalCalories():f2}");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);     
            }

        }
    }
}
