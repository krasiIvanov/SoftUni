using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    class Topping
    {
        private readonly string[] TOPPING_TYPES=new string[]{ "meat", "veggies", "sauce", "cheese" };

        private string type;
        private double weight;

        public Topping(string type, double weight)
        {

            this.Type = type;
            this.Weight = weight;

        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value<1 || value>50)
                {
                    throw new ArgumentException($"{this.type} weight should be in the range[1..50].");
                }
                weight = value;
            }
        }


        public string Type
        {
            get { return type; }
            set
            {
                if (!TOPPING_TYPES.Contains(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                type = value;
            }
        }

        public double GetToppingCalories()
        {
            double toppingModifier = 0;

            switch (this.type.ToLower())
            {
                case "meat":toppingModifier = 1.2;
                    break;
                case "veggies":
                    toppingModifier = 0.8;
                    break;
                case "cheese":
                    toppingModifier = 1.1;
                    break;
                case "sauce":
                    toppingModifier = 0.9;
                    break;
                default:
                    toppingModifier = 0;
                    break;
            }

            double totalCalories = (2 * this.weight) * toppingModifier;
            return totalCalories;


        }
    }
}
