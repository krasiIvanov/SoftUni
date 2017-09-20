using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Kittens : Cat
    {
        

        public Kittens(string name, int age, string gender) 
            : base(name, age, gender)
        {
        }

        public override string Gender
        {
            get
            {
                return base.Gender;
            }

            set
            {
                if (value.ToLower() !="female")
                {
                    throw new ArgumentException("Invalid input!");
                }
                base.Gender = value;
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Miau");
        }
    }
}
