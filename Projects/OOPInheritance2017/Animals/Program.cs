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
            List<Animal> animals = new List<Animal>();

            string kind = Console.ReadLine();

            while (kind!="Beast!")
            {
                string[] animalTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = animalTokens[0];
                int age = int.Parse(animalTokens[1]);
                string gender = null;
                if (animalTokens.Length>2)
                {
                    gender = animalTokens[2];
                }
                try
                {
                    Animal newAnimal = AnimalFactory.MakeAnimal(kind,name,age,gender);
                    animals.Add(newAnimal);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

                kind = Console.ReadLine();
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
