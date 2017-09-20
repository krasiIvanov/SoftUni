using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType,string bakingTechnique,double weight)
        {

            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get
            {
                return this.flourType;
            }
            private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;
            }
        }
        public string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }

            private set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value;
            }
        }
        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value<1 || value>200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

        public double CaloriesOfADought()
        {
            double flourTypeModifier=0;
            double bakingModifier = 0;
            if (this.flourType=="white")
            {
                flourTypeModifier = 1.5;
            }
            else
            {
                flourTypeModifier = 1;
            }

            switch (this.bakingTechnique)
            {
                case "crispy":bakingModifier = 0.9;
                    break;
                case "chewy":bakingModifier = 1.1;
                    break;
                case "homemade":bakingModifier = 1.0;
                    break;
                default:
                    break;
            }

            double calories = (2 * this.weight) * flourTypeModifier * bakingModifier;

            return calories;
        }

    }
}
