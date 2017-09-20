using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldestFamilyMember
{
    class Family
    {

        private List<Person> familyList;

        public Family()
        {
            this.familyList = new List<Person>();
        }

        public void AddMember(Person person)
        {
            familyList.Add(person);
        }

        public void GetOldestMember()
        {
            Person oldest = familyList.OrderByDescending(p => p.Age).First();
            Console.WriteLine(oldest);
        }

        public void GetMembersOver30()
        {
            List<Person> membersOver30 = familyList.Where(p => p.Age > 30).ToList();

            foreach (var item in membersOver30.OrderBy(p=>p.Name))
            {
                Console.WriteLine(item);
            }
        }


    }
}
