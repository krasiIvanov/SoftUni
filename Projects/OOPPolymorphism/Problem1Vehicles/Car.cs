using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Vehicles
{
    class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelPerKm,double tankCapacity)
            : base(fuelQuantity, fuelPerKm, tankCapacity)
        {
        }

        public override void Drive(double km)
        {
            double curentConsumption = base.FuelPerKm + 0.9;
            double neededFuel = curentConsumption * km;

            if (neededFuel>base.FuelQuantity)
            {
                throw new InvalidOperationException("Car needs refueling");
            }

            Console.WriteLine($"Car travelled {km} km");
            base.FuelQuantity -= neededFuel;
        }
        
        
        public override void Refuel(double fuel)
        {
            if (fuel<0)
            {
                throw new InvalidOperationException("Fuel must be a positive number");
            }
            double totalFuel = base.FuelQuantity + fuel;
            if (totalFuel>base.TankCapacity)
            {
                throw new InvalidOperationException("Cannot fit fuel in tank");
            }
            base.FuelQuantity += fuel;
        }
    }
}
