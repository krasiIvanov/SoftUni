using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;
        private int numberOfToppings;

        public Pizza(string name, int numberOfToppings)
        {
            this.Name = name;            
            this.toppings = new List<Topping>();
            this.NumberOfToppings = numberOfToppings;
        }

        public Dough Dough
        {
            get { return dough; }
            set { this.dough = value; }
            
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length>15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        public int NumberOfToppings
        {
            get { return numberOfToppings; }
            set
            {
                if (value>10 || value<0)
                {
                    throw new InvalidOperationException("Number of toppings should be in range [0..10].");
                }
                this.numberOfToppings = value;
            }
        }


        public void AddTopping(Topping topping)
        {
            this.toppings.Add(topping);
            
        }

        public double GetTotalCalories()
        {
            double toppingsCalories = 0;
            double doughCalories = this.dough.GetDoughCalories();

            foreach (var top in toppings)
            {
                toppingsCalories += top.GetToppingCalories();
            }

            double total = toppingsCalories + doughCalories;

            return total;
        }

    }
}
