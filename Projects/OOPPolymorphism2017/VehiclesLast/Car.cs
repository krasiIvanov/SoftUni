using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLast
{
    class Car : Vehicle
    {
        private const double AIR_INCREASED = 0.9;

        public Car(double quantity, double consumption, double tankCapacity) : base(quantity, consumption+AIR_INCREASED, tankCapacity)
        {
        }
    }
}
