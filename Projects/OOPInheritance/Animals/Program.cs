using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            string animalType = Console.ReadLine();

            while (animalType!="Beast!")
            {

                string[] animalInfo = Console.ReadLine().Split();
                string name = animalInfo[0];
                int age = int.Parse(animalInfo[1]);
                string gender = animalInfo[2];

                try
                {
                    switch (animalType)
                    {
                        case "Cat":Cat cat = new Cat(name, age, gender);
                            Console.WriteLine(cat);
                            cat.MakeSound();
                            break;
                        case "Dog":
                            Dog dog = new Dog(name, age, gender);
                            Console.WriteLine(dog);
                            dog.MakeSound();
                            break;
                        case "Frog":
                            Frog frog = new Frog(name, age, gender);
                            Console.WriteLine(frog);
                            frog.MakeSound();
                            break;
                        case "Kittens":
                            Kittens kittens = new Kittens(name, age, gender);
                            Console.WriteLine(kittens);
                            kittens.MakeSound();
                            break;
                        case "Tomcat":
                            Tomcat tomcat = new Tomcat(name, age, gender);
                            Console.WriteLine(tomcat);
                            tomcat.MakeSound();
                            break;
                        default:
                            break;
                    }
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }

                animalType = Console.ReadLine();
            }
        }
    }
}
