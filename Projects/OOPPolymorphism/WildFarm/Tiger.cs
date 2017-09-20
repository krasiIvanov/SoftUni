using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    class Tiger : Feline
    {
        
        public Tiger(string animalType, string animalName, double animalWeight, string livingRegion) 
            : base(animalType, animalName, animalWeight, livingRegion)
        {
            
        }
        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }
        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Vegetable")
            {
                throw new InvalidOperationException($"{this.GetType().Name} are not eating that type of food!");
            }
            base.FoodEaten=food.Quantity;
        }
        public override string ToString()
        {
            string result = $"{this.GetType().Name}[{base.AnimalName}, {base.AnimalWeight},{this.LivingRegion}, {base.FoodEaten} ";
            return result;
        }

    }
}
