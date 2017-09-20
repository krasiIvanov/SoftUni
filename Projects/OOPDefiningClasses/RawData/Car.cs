using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
   public class Car
    {
        public string model;
        public Engine engine;
        public Cargo cargo;
        public Tier[] tiers;

        public Car(string model, Engine engine, Cargo cargo, Tier[] tiers)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tiers = tiers;
        }
    }
}
