using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLast
{
    class Truck : Vehicle
    {
        private const double AIR_INCREASED = 1.6;
        private const double FUEL_LOSS = 0.95;

        public Truck(double quantity, double consumption, double tankCapacity) : base(quantity, consumption+AIR_INCREASED, tankCapacity)
        {
        }

        public override void Refueling(double fuel)
        {
            double totalFuel = fuel * FUEL_LOSS;
            if (fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            base.FuelQuantity += totalFuel;
        }
    }
}
