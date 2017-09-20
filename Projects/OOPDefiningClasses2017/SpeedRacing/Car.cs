using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    class Car
    {

        private string model;
        private double fuelAmount;
        private double fuelConsumption;
        private int distanceTravel;

        public Car(string model,double fuelAmount,double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumption = fuelConsumption;
            this.DistanceTravel = 0;
        }

        public string Model { get => model; set => model = value; }
        public double FuelAmount { get => fuelAmount; set => fuelAmount = value; }
        public double FuelConsumption { get => fuelConsumption; set => fuelConsumption = value; }
        public int DistanceTravel { get => distanceTravel; set => distanceTravel = value; }


        public void Drive(int distance)
        {
            double consumation = distance * fuelConsumption;
            if (consumation > fuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.distanceTravel += distance;
                fuelAmount -= consumation;

            }
        }

        public override string ToString()
        {
            string result = $"{this.Model} {this.fuelAmount:f2} {this.DistanceTravel}";
            return result;
        }
    }
}
