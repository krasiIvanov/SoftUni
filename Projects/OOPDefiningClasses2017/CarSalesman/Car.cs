using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(string model,Engine engine,int weight,string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }
        public Car(string model,Engine engine):this(model,engine,-1,"n/a")
        {

        }
        public Car(string model, Engine engine, int weight):this(model,engine,weight,"n/a")
        {

        }
        public Car(string model,Engine engine,string color):this(model,engine,-1,color)
        {

        }

        public string Model { get => model; set => model = value; }
        public int Weight { get => weight; set => weight = value; }
        public string Color { get => color; set => color = value; }
        internal Engine Engine { get => engine; set => engine = value; }

        

        public override string ToString()
        {
            string weightResult = this.weight.ToString() ;
            string displacement = this.engine.Displacement.ToString();

            if (this.weight==-1)
            {
                weightResult = "n/a";
            }
            if (this.engine.Displacement == -1)
            {
                displacement = "n/a";
            }
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.model}:")
                .Append(Environment.NewLine)
                .Append($"  {this.engine.Model}:")
                .Append(Environment.NewLine)
                .Append($"    Power: {this.engine.Power}")
                .Append(Environment.NewLine)
                .Append($"    Displacement: {displacement}")
                .Append(Environment.NewLine)
                .Append($"    Efficiency: {this.engine.Efficiency}")
                .Append(Environment.NewLine)
                .Append($"  Weight: {weightResult} ")
                .Append(Environment.NewLine)
                .Append($"  Color: {this.color} ");
                

            return sb.ToString();
        }
    }
}
