using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLast
{
   public abstract class Vehicle
    {

        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        


        public Vehicle(double quantity, double consumption,double tankCapacity)
        {
            this.FuelQuantity = quantity;
            this.FuelConsumption = consumption;
            this.TankCapacity = tankCapacity;
        }

        protected double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            set
            {
                this.fuelQuantity = value;
            }
        }
        protected double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                this.fuelConsumption = value;
            }
        }
        protected double TankCapacity
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


        public  void Drive (double distance)
        {
            double requestedFuel = distance * FuelConsumption;
            if (requestedFuel>FuelQuantity)
            {
                throw new InvalidOperationException("Car needs refueling");
            }
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            
            FuelQuantity -= requestedFuel;
        }
        public void Drive(double distance,bool isEmpty)
        {
            if (isEmpty)
            {
                double airIncrease = 1.4;
                fuelConsumption -= airIncrease;
                Drive(distance);
                fuelConsumption += airIncrease;
                
            }
            else
            {
                Drive(distance);
            }
            

        }
        public virtual void Refueling(double fuel)
        {
            if (fuel<=0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (FuelQuantity+fuel>tankCapacity)
            {
                throw new InvalidOperationException("Cannot fit fuel in tank");
            }
            FuelQuantity += fuel;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
