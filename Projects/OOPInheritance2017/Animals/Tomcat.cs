using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Tomcat : Cat
    {
        private const string GENDER = "Male";
        public Tomcat(string name, int age) : base(name, age, GENDER)
        {
        }
        public override string MakeSound()
        {
            return "Give me one million b***h";
        }
    }
}
