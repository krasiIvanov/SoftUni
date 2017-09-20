using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    class Engine
    {
        //model, power, displacement and efficiency.
        public string model;
        public int power;
        public string displacement="n/a";
        public string efficency = "n/a";

        public Engine(string model,int power)
        {
            this.model = model;
            this.power = power;
        }
        public override string ToString()
        {
            return $"{model}: Power: {this.power} Displacement: {this.displacement} Efficency: {efficency}";
        }
    }
}
