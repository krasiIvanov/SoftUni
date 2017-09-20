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

            while (input!="End")
            {

                string[] inputTokens = input.Split(' ');

                string personName = inputTokens[0];

                if (!persons.ContainsKey(personName))
                {
                    Person newPerson = new Person(personName);
                    persons.Add(personName, newPerson);
                }

                string cmd = inputTokens[1];

                switch (cmd)
                {
                    case "company":
                        string companyName = inputTokens[2];
                        string department = inputTokens[3];
                        decimal salary = decimal.Parse(inputTokens[4]);
                        Company company = new Company(companyName,department,salary);
                        persons[personName].Company = company;
                        break;
                    case "car":
                        string carName = inputTokens[2];
                        int speed = int.Parse(inputTokens[3]);
                        Car car = new Car(carName, speed);
                        persons[personName].Car = car;
                        break;
                    case "pokemon":
                        string pokemonName = inputTokens[2];
                        string type = inputTokens[3];
                        Pokemon pokemon = new Pokemon(pokemonName, type);
                        persons[personName].AddPokemon(pokemon);
                        break;
                    case "parents":
                        string parentName = inputTokens[2];
                        string parentBirthday = inputTokens[3];
                        Parents parent = new Parents(parentName, parentBirthday);
                        persons[personName].AddParent(parent);
                        break;
                    case "children":
                        string childrenName = inputTokens[2];
                        string childrenBirthday = inputTokens[3];
                        Children children = new Children(childrenName, childrenBirthday);
                        persons[personName].AddChildren(children);
                        break;
                    default:
                        break;
                }


                input = Console.ReadLine();
            }

            string name = Console.ReadLine();

            Console.WriteLine
                (
                persons[name]
                .ToString()
                .Replace(Environment.NewLine + Environment.NewLine, Environment.NewLine)
                .TrimEnd()
                );

        }
    }
}
