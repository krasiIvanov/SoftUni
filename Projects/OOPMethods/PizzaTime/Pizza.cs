using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime
{
    class Pizza
    {

        public static SortedDictionary<int, List<string>> pizzaByGroups = new SortedDictionary<int, List<string>>();

        public int group;
        public string name;

        public Pizza(int group, string name)
        {
            this.group = group;
            this.name = name;
        }
    }
}
