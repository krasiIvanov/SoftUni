using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.AnimalModels
{
    public class Cat : Felime
    {
        public Cat(string animalType, string animalName, double animalWeight, string livingRegion,string catBreed) 
            : base(animalType, animalName, animalWeight, livingRegion)
        {
            this.CatBreed = catBreed;
        }

        public string CatBreed { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }
        public override void Eat(Food food)
        {
            base.FoodEaten += food.Quantity;
        }
    }
}
