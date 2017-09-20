using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.AnimalModels
{
    public abstract class Mammal : Animal
    {

        public string  LivingRegion { get; set; }

        public Mammal(string animalType, string animalName, double animalWeight, string livingRegion )
        {
            base.AnimalType = animalType;
            base.AnimalName = animalName;
            base.AnimalWeight = animalWeight;
            this.LivingRegion = livingRegion;
        }

        public override void Eat(Food food)
        {
            Console.WriteLine("");
        }

        public override void MakeSound()
        {
            Console.WriteLine("");
        }
    }
}
