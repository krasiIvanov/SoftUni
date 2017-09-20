using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.AnimalModels
{
    public class Tiger : Felime
    {
        public Tiger(string animalType, string animalName, double animalWeight, string livingRegion)
            : base(animalType, animalName, animalWeight, livingRegion)
        {
        }
        public override void Eat(Food food)
        {
            if (food.GetType().Name== "Vegetable")
            {
                throw new InvalidOperationException("");
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }
    }
}
