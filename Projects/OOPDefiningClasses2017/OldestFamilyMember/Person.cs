using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldestFamilyMember
{
    class Person
    {

        private string name;
        private int age;

        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;

        }

        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            string result = $"{this.name} {this.age}";
            return result;
        }
    }
}
