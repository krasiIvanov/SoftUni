using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : Animal
    {
        private const string Sound = "MiauMiau";
        public Cat(string name, int age, string gender) 
            : base(name, age, gender)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(Sound);
        }
    }
}
