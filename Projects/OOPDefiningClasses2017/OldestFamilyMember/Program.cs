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
            Family family = new Family();
            for (int i = 0; i < num; i++)
            {
                string[] personInfo = Console.ReadLine().Split();

                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                Person newPerson = new Person(name, age);
                family.AddMember(newPerson);


            }
            //family.GetOldestMember();
            family.GetMembersOver30();
        }
    }
}
