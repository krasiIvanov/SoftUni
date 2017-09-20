using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    class Cat : Feline
    {
        private string breed;

        public Cat(string animalType, string animalName, double animalWeight, string livingRegion,string breed) 
            : base(animalType, animalName, animalWeight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed
        {
            get
            {
                return breed;
            }

            set
            {
                breed = value;
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }
        public override void Eat(Food food)
        {
            base.FoodEaten=food.Quantity;
        }
        public override string ToString()
        {
            string result = $"{this.GetType().Name}[{base.AnimalName}, {this.breed}, {base.AnimalWeight},{base.LivingRegion}, {base.FoodEaten} ";
            return result;
        }
    }
}
