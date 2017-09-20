using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class FamelyMember
    {
        private string name;
        private string birthday;

        public FamelyMember(string name,string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public string Name { get => name; set => name = value; }
        public string Birthday { get => birthday; set => birthday = value; }

        public override string ToString()
        {
            string result = $"{name} {birthday}";
            return result;
        }
    }
}
