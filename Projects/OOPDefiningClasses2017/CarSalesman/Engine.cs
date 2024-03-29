﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    class Engine
    {

        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public Engine(string model,int power, int displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }
        public Engine(string model,int power):this(model,power,-1,"n/a")
        {

        }
        public Engine(string model, int power, int displacement):this(model,power,displacement,"n/a")
        {

        }
        public Engine(string model, int power, string efficiency) : this(model, power, -1, efficiency)
        {

        }

        public string Model { get => model; set => model = value; }
        public int Power { get => power; set => power = value; }
        public int Displacement { get => displacement; set => displacement = value; }
        public string Efficiency { get => efficiency; set => efficiency = value; }
    }
}
