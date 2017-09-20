using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DefineClassPerson;
namespace OppininPoll
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesNum = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();

            for (int i = 0; i < linesNum; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person newPerson = new Person(name, age);
                persons.Add(newPerson);
            }

            var sortedPersons = persons.Where(p => p.age > 30).OrderBy(p => p.name).ToList();

            foreach (var person in sortedPersons)
            {
                Console.WriteLine($"{person.name} {person.age}");
            }
        }
    }
}
