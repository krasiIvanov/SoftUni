using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
   public  class Vehicles
    {

        private double fuelQuantity;
        private double fuelConsumption;

        public Vehicles(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get => fuelQuantity;  set => fuelQuantity = value; }
        public double FuelConsumption { get => fuelConsumption;  set => fuelConsumption = value; }

        public  void Drive(double distance)
        {
            double fuel = distance * fuelConsumption;
            if (fuel>fuelQuantity)
            {
                throw new InvalidOperationException($"{this.GetType().Name} needs refueling");
            }
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            fuelQuantity -= fuel;
        }
        public virtual void Refueled(double fuel)
        {
            fuelQuantity += fuel;
        }
    }
}
