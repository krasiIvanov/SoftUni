using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Vehicles
    {
        private const double INCREASE_CONSUMPTION = 1.6;
        private const double FUEL_LOSS = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption+INCREASE_CONSUMPTION)
        {
        }

        public override void Refueled(double fuel)
        {
            base.Refueled(fuel*FUEL_LOSS);
        }

    }
}
