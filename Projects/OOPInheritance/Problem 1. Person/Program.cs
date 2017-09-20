using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Person
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();   
            int age = int.Parse(Console.ReadLine());

            try
            {
                Child child = new Child(name, age);
                
                Console.WriteLine(child);
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
