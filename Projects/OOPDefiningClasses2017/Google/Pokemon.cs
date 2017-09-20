using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Pokemon
    {
        private string name;
        private string type;

        public Pokemon(string name,string type)
        {
            this.Name = name;
            this.Type = type;
        }

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }

        public override string ToString()
        {
            string result = $"{this.name} {this.type}";
            return result;
        }
    }
}
