using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldestFamilyMember
{
    class Family
    {
        List<Person> people;

        public Family(List<Person> people)
        {
            this.people = people;
        }

        public void AddMember(Person person)
        {
            this.people.Add(person);
        }

        public Person GetOldestMember()
        {
            Person result = this.people.OrderByDescending(p => p.age).First();
            
            return result;
        }
    }
}
