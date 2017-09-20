using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    class Topping
    {

        private string toppingType;
        private double toppingWeight;

        public Topping(string toppingType,double toppingWeight)
        {
            this.ToppingType = toppingType;
            this.ToppingWeight = toppingWeight;
        }

        public string ToppingType
        {
            get
            {
                return this.toppingType;
            }
           private  set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.toppingType = value;
            }
        }
        public double ToppingWeight
        {
            get
            {
                return this.toppingWeight;
            }
           private set
            {
                if (value<1 || value>50)
                {
                    throw new ArgumentException($"{this.ToppingType} weight should be in the range[1..50].");
                }
                this.toppingWeight = value;
            }
        }
        public double CaloriesOfATopping()
        {
            double modifeir = 0;
            switch (this.toppingType)
            {
                case "meat":
                    modifeir = 1.2;
                    break;
                case "veggies":
                    modifeir = 0.8;
                    break;
                case "cheese":
                    modifeir = 1.1;
                    break;
                case "sauce":
                    modifeir = 0.9;
                    break;
                default:
                    break;
            }
            double calories = (2 * this.toppingWeight) * modifeir;
            return calories;
        }


    }
}
