using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
   public class Cargo
    {
        public int cargoWeight;
        public string cargoType;

        public Cargo(int cargoWeight,string cargoType)
        {
            this.cargoWeight = cargoWeight;
            this.cargoType = cargoType;
        }

    }
}
