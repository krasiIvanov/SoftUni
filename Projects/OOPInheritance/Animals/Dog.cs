﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : Animal
    {
        private const string Sound = "BauBau";

        public Dog(string name, int age, string gender) 
            : base(name, age, gender)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(Sound);
        }
    }
}
