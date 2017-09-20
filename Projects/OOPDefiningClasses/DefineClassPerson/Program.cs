using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClassPerson
{
    public class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person() : this("No name", 1)
        {

        }

        public Person(int age) : this("No name",age)
        {

        }

        


    }

    class Program
    {
        static void Main(string[] args)
        {

            Person Person1 = new Person();
            Console.WriteLine($"{Person1.name} - {Person1.age}");

        }
    }
}
