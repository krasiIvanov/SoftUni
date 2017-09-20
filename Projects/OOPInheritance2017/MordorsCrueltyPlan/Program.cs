using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordorsCrueltyPlan
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] foodNames = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<Food> foods = new List<Food>();
            foreach (var food in foodNames)
            {
                Food newFood = FoodFactory.GetFood(food);
                foods.Add(newFood);
            }
            var gandalf = new Gandalf();
            gandalf.Eat(foods);

            Console.WriteLine(gandalf);
            

        }
    }
}
