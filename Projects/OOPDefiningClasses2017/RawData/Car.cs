using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    class Car
    {

        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tires;

        public Car(string model,Engine engine,Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.tires = new List<Tire>();
        }

        public string Model { get => model; set => model = value; }
        internal Engine Engine { get => engine; set => engine = value; }
        internal Cargo Cargo { get => cargo; set => cargo = value; }
        internal List<Tire> Tires { get => tires;  }

        public void AddTire(Tire tire)
        {
            this.Tires.Add(tire);
        }
    }
}
