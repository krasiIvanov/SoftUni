using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    class Dough
    {
        private readonly string[] FLOUR_TYPES = new string[] { "white", "wholegrain" };
        private readonly string[] BAKING_TECHNIQUE = new string[] { "crispy", "chewy", "homemade" };

        private string flourType;
        private string bakingTechnique ;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value<0 || value>200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }

        public string BakingTechnique
        {
            get { return bakingTechnique ; }
            set
            {
                if (!BAKING_TECHNIQUE.Contains(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                bakingTechnique  = value;
            }
        }

        public string FlourType
        {
            get { return flourType; }
            set
            {
                if (!FLOUR_TYPES.Contains(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourType = value;
            }
        }

        public double GetDoughCalories()
        {
            double flourModifier;
            double bakingModifier;

            switch (this.flourType.ToLower())
            {
                case "white":flourModifier = 1.5;
                    break;
                case "wholegrain":flourModifier = 1.0;
                    break;
                default:
                    flourModifier = 0;
                    break;
            }

            switch (this.bakingTechnique.ToLower())
            {
                case "crispy":
                    bakingModifier = 0.9;
                    break;
                case "chewy":
                    bakingModifier = 1.1;
                    break;
                case "homemade":
                    bakingModifier = 1.0;
                    break;

                default:
                    bakingModifier = 0;
                    break;
            }

            double totalCalories = (2 * this.weight) * flourModifier * bakingModifier;

            return totalCalories;

        }


    }
}
