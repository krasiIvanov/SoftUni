using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Car
    {

        private string name;
        private int speed;

        public Car(string name, int speed)
        {
            this.Name = name;
            this.Speed = speed;
        }

        public string Name { get => name; set => name = value; }
        public int Speed { get => speed; set => speed = value; }

        public override string ToString()
        {
            string result = $"{this.name} {this.speed}";
            return result;
        }
    }
}
