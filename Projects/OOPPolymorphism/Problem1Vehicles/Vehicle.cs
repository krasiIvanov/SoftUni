using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Vehicles
{
   public abstract class Vehicle
    {

        private double fuelQuantity;
        private double fuelPerKm;
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelPerKm, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelPerKm = fuelPerKm;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity
        {
            get
            {
                return fuelQuantity;
            }

            set
            {
                
                fuelQuantity = value;
            }
        }

        public double FuelPerKm
        {
            get
            {
                return fuelPerKm;
            }

            set
            {
               
                fuelPerKm = value;
            }
        }

        public virtual double TankCapacity
        {
            get
            {
                return tankCapacity;
            }

            set
            {

                tankCapacity = value;
            }
        }

        public abstract void Drive(double km);
        public abstract void Refuel(double fuel);

        public override string ToString()
        {
            string result = $"{this.GetType().Name}: {this.fuelQuantity:f2}";

            return result;
        }
    }
}
