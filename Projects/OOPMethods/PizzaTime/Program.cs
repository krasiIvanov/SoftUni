using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PizzaTime
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();
            string patern = @"(\d+)(\w+)";
            Regex matcher = new Regex(patern);
            List<Pizza> pizzas = new List<Pizza>();
            for (int i = 0; i < input.Length ; i++)
            {
                Match match = matcher.Match(input[i]);
                Pizza pizza = new Pizza(int.Parse(match.Groups[1].Value),match.Groups[2].Value);
                if (!Pizza.pizzaByGroups.ContainsKey(int.Parse(match.Groups[1].Value)))
                {
                    Pizza.pizzaByGroups.Add(int.Parse(match.Groups[1].Value), new List<string>());
                }
                Pizza.pizzaByGroups[int.Parse(match.Groups[1].Value)].Add(match.Groups[2].Value);
            } 

        }
    }
}
