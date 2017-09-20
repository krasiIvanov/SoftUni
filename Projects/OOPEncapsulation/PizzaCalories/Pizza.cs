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
        private int numberOfToppings;
        private List<Topping> topings;
        private Dough dough;

        public Pizza(string name,int numberOfToppings,Dough dough)
        {
            this.Name = name;
            this.NumberOfToppings = numberOfToppings;
            this.dough = dough;
            this.topings = new List<Topping>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrEmpty(value) || value.Length>15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }
        public int NumberOfToppings
        {
            get
            {
                return this.numberOfToppings;
            }
           private set
            {
                if (value<0 || value>10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                this.numberOfToppings = value;
            }
        }

        public double totalPizzaCalories()
        {
            return allToppingsCallories() + this.dough.CaloriesOfADought();
        }

        public void addTopping(Topping topping)
        {
            this.topings.Add(topping);
        }

        private double allToppingsCallories()
        {
            double totalCalories = 0;
            foreach (var item in topings)
            {
                double itemCalories = item.CaloriesOfATopping();

                totalCalories += itemCalories;
            }
            return totalCalories;
        }

        public override string ToString()
        {
            string result = $"{this.name} – {this.totalPizzaCalories():f2} Calories.";
            return result;
        }

    }
}
