using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    abstract class Mammal : Animal
    {
        private string livingRegion;

        public Mammal(string animalType, string animalName, double animalWeight,string livingRegion)
            : base(animalType, animalName, animalWeight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion
        {
            get
            {
                return livingRegion;
            }

            set
            {
                livingRegion = value;
            }
        }

        public override void Eat(Food food)
        {
            Console.WriteLine("kor");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Sound");
        }

        

    }
}
