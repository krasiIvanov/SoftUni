using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            Dictionary<string, Person> persons = new Dictionary<string, Person>();

            while (input != "End")
            {

                string[] tokens = input.Split(' ');
                string name = tokens[0];
                string infoType = tokens[1];
                string firstElement = tokens[2];
                string secondElement = tokens[3];
                if (!persons.ContainsKey(name))
                {
                    Person newPerson = new Person(name);
                    persons.Add(name, newPerson);
                    switch (infoType)
                    {
                        case "company":
                            decimal salary = decimal.Parse(tokens[4]);
                            Company newCompany = new Company(firstElement, secondElement, salary);
                            persons[name].company = newCompany;
                            break;
                        case "car":
                            int speed = int.Parse(secondElement);
                            Car newCar = new Car(firstElement, speed);
                            persons[name].car = newCar;
                            break;
                        case "pokemon":
                            Pokemon newPokemon = new Pokemon(firstElement, secondElement);
                            persons[name].pokemons.Add(newPokemon);
                            break;
                        case "parents":
                            Parent newParent = new Parent(firstElement, secondElement);
                            persons[name].parents.Add(newParent);
                            break;
                        case "children":
                            Childern newChildren = new Childern(firstElement, secondElement);
                            persons[name].childrens.Add(newChildren);
                            break;
                        default:
                            break;
                    }

                }
                else
                {
                    switch (infoType)
                    {
                        case "company":
                            decimal salary = decimal.Parse(tokens[4]);
                            Company newCompany = new Company(firstElement,secondElement,salary);
                            persons[name].company = newCompany;
                            break;
                        case "car":
                            int speed = int.Parse(secondElement);
                            Car newCar = new Car(firstElement,speed);
                            persons[name].car = newCar;
                            break;
                        case "pokemon":
                            Pokemon newPokemon = new Pokemon(firstElement,secondElement);
                            persons[name].pokemons.Add(newPokemon);
                            break;
                        case "parents":
                            Parent newParent = new Parent(firstElement,secondElement);
                            persons[name].parents.Add(newParent);
                            break;
                        case "children":
                            Childern newChildren = new Childern(firstElement, secondElement);
                            persons[name].childrens.Add(newChildren);
                            break;
                        default:
                            break;
                    }
                }
                input = Console.ReadLine();
            }
            string result = Console.ReadLine();
            Console.WriteLine(persons[result].ToString());

        }
        
    }
}
