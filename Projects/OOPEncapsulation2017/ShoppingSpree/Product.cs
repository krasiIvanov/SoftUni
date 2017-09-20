using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    class Product
    {

        private string name;
        private decimal cost;


        public Product(string name, decimal cost)
        {

            this.Name = name;
            this.Cost = cost;

        }

        public decimal Cost
        {
            get { return cost; }
            set
            {
                if (this.cost<0)
                {
                    throw new ArgumentException($"{nameof(Cost)} cannot be negative");
                }
                cost = value;
            }
        }


        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(Name)} cannot be empty");
                }
                name = value;
            }
        }

        public override string ToString()
        {
            return this.name;
        }

    }
}
