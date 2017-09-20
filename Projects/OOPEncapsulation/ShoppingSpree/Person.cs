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
        private List<Product> products;

        public Person(string name,decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException($"{nameof(this.Name)} cannot be empty ");
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
                    throw new ArgumentException($"{nameof(this.Money)} cannot be negative ");
                }
                this.money = value;
            }
        }

        public void BuyProduct(Product product)
        {
            if (product.Cost>this.money)
            {
                throw new InvalidOperationException($"{this.name} can't afford {product.Name}");
            }
            this.money -= product.Cost;
            products.Add(product);
            Console.WriteLine($"{this.name} bought {product.Name}");
        }

        public override string ToString()
        {
            string result = $"{this.name} - {String.Join(", ",products)}";
            if (products.Count==0)
            {
                result = $"{this.name} - Nothing bought";
            }
            return result;
        }
    }
}
