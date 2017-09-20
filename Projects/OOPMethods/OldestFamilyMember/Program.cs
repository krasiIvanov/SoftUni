using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = int.Parse(Console.ReadLine());
            Family family = new Family(new List<Person>());
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                int age =int.Parse( input[1]);
                Person newPerson = new Person(name, age);
                family.AddMember(newPerson);

            }
            Person oldestMember = family.GetOldestMember();
            Console.WriteLine(oldestMember.ToString());
        }
    }
}
