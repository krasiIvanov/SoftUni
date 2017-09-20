using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Car : Vehicles
    {
        private const double INCREASE_CONSUMPTION = 0.9;
        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption+INCREASE_CONSUMPTION)
        {
        }

       
    }
}
