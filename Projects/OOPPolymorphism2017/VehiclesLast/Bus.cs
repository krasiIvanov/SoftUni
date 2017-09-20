using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLast
{
    class Bus : Vehicle
    {
        private const double AIR_INCREASED = 1.4;

        public Bus(double quantity, double consumption, double tankCapacity) : base(quantity, consumption+AIR_INCREASED, tankCapacity)
        {
        }

       
    }
}
