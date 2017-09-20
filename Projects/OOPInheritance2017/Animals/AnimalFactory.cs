using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class AnimalFactory
    {

        public static Animal MakeAnimal(string kind, string name, int age, string gender=null)
        {
            switch (kind)
            {
                case "Cat":
                    return new Cat(name,age,gender);
                case "Dog":
                    return new Dog(name, age, gender);
                case "Frog":
                    return new Frog(name, age, gender);
                case "Tomcat":
                    return new Tomcat(name, age);
                case "Kitten":
                    return new Kitten(name, age);
                    
                default:
                    throw new ArgumentException("Invalid input!");
            }

        }

    }
}
