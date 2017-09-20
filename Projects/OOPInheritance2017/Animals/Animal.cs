using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
   public abstract class Animal
    {

        private string name;
        private int age;
        private string gender;

        public Animal(string name,int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        private string Gender
        {
            
             set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                gender = value;
            }
        }


        private int Age
        {
            
             set
            {
                if (value<0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                age = value;
            }
        }


        private string Name
        {
            
             set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                name = value;
            }
        }

        public abstract string MakeSound();

        public override string ToString()
        {
            return $"{this.GetType().Name}\n\r{this.name} {this.age} {this.gender}\n\r{this.MakeSound()}";
        }


    }
}
