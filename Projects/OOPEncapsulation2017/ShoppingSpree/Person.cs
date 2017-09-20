using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    class Person
    {

        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name, decimal money)
        {

            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();

        }


        public void BuyProduct(Product product)
        {
            if (product.Cost>this.money)
            {
                throw new InvalidOperationException($"{this.name} can't afford {product.Name}");
            }
            Console.WriteLine($"{this.name} bought {product.Name}");
            bag.Add(product);
            money -= product.Cost;
        }
        
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(this.Name)} cannot be empty");
                }
                this.name = value;
            }
        }
        public decimal Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException($"{nameof(Money)} cannot be negative");
                }
                this.money = value;
            }
        }
        public List<Product> Bag { get => bag;  }

        public override string ToString()
        {
            string result;
            if (bag.Count==0)
            {

                result = $"{this.name} - Nothing bought";

            }
            else
            {
                result = $"{this.name} - {string.Join(", ", this.bag)}";
            }
             

            return result;
        }
    }
}
