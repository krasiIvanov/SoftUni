using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    class Car
    {
        public string model;
        public Engine engine;
        public string weight="n/a";
        public string color="n/a";

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
        }

        public override string ToString()
        {
            return $"{this.model}: {this.engine.model}: Power: {this.engine.power} Displacement: {this.engine.displacement} Efficiency: {this.engine.efficency} Weight: {this.weight} Color: {this.color}";
        }
    }

    
}
