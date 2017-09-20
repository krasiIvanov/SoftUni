using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = null;
            string[] tokens = Console.ReadLine().Split(' ');
            string animalType = tokens[0];
            string animalName = tokens[1];
            double animalWeight =double.Parse(tokens[2]);
            string animalLivingRegion = tokens[3];
            
            switch (animalType)
            {
                case "Cat":
                    string catBreed = tokens[4];
                    animal = new Cat(animalType,animalName,animalWeight,animalLivingRegion,catBreed);
                    break;
                case "Tiger":
                    animal = new Tiger(animalType, animalName, animalWeight, animalLivingRegion);
                    break;
                case "Zebra":
                    animal = new Zebra(animalType, animalName, animalWeight, animalLivingRegion);
                    break;
                case "Mouse":
                    animal = new Mouse(animalType, animalName, animalWeight, animalLivingRegion);
                    break;
                default:
                    break;
            }

            string[] foodTokens = Console.ReadLine().Split(' ');
            string foodType = foodTokens[0];
            int foodQuantity = int.Parse(foodTokens[1]);
            Food food = null;

            switch (foodType)
            {
                case "Vegetable":
                    food = new Vegetable(foodQuantity);
                    break;
                case "Meal":
                    food = new Meat(foodQuantity);
                    break;
                default:
                    break;
            }
            try
            {
                animal.MakeSound();
                animal.Eat(food);
               
            }
            catch (InvalidOperationException ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(animal);
        }
    }
}
