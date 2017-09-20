using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {

        public int speed;
        public double fuel;
        public int fuelEconomy;
        public double distanceTravel;

        public Car(int speed, double fuel, int fuelEconomy)
        {
            this.speed = speed;
            this.fuel = fuel;
            this.fuelEconomy = fuelEconomy;
        }
        public void Travel(double distance)
        {
            double fuelPerKm = this.fuelEconomy / 100d;
            double totalFuelUsed = distance * fuelPerKm;
            if (totalFuelUsed<=this.fuel)
            {
                this.fuel -= totalFuelUsed;
                this.distanceTravel += distance;
            }
            else
            {
                double kmTravel = this.fuel / fuelPerKm;
                this.distanceTravel += kmTravel;
                this.fuel -= totalFuelUsed;
            }
        }
        public void Refuel(double fuel)
        {
            this.fuel += fuel;
        }

        public double Distance()
        {
            return this.distanceTravel;
        }

        public double Time()
        {
            double totalTime = (this.distanceTravel / this.speed)*60;

            return totalTime;
        }
        public double Fuel()
        {
            return this.fuel;
        }
    }
}
