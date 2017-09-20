using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Vehicles
{
    class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelPerKm, tankCapacity)
        {
        }

        public override void Drive(double km)
        {
            double curentConsumption = base.FuelPerKm + 1.6;
            double neededFuel = curentConsumption * km;

            if (neededFuel > base.FuelQuantity)
            {
                throw new InvalidOperationException("Truck needs refueling");
            }

            Console.WriteLine($"Truck travelled {km} km");
            base.FuelQuantity -= neededFuel;
        }

        public override void Refuel(double fuel)
        {
            if (fuel < 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            double finalFuel = (95.0 / 100.0) * fuel;
            base.FuelQuantity += finalFuel;
        }

    }
}
