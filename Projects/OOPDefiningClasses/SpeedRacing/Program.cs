using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    class Car
    {
        public string model;
        public double fuelAmount;
        public double fuelCostPerKm;
        public double distanceTraveled = 0;

        public Car(string model, double fuelAmount, double fuelCostPerKm)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelCostPerKm = fuelCostPerKm;
        }

        public void Drive(Car car, double distance)
        {
            if (distance*car.fuelCostPerKm>car.fuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                car.fuelAmount -= distance * car.fuelCostPerKm;
                car.distanceTraveled += distance;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            //List<Car> cars = new List<Car>();
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < num; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                string model = tokens[0];
                double fuelAmount = double.Parse(tokens[1]);
                double fuelCostPerKm = double.Parse(tokens[2]);
                Car newCar = new Car(model, fuelAmount, fuelCostPerKm);
                cars.Add(model, newCar);
               // cars.Add(newCar);
            }
            string input = Console.ReadLine();
            while (input!="End")
            {

                string[] tokens = input.Split(' ');
                string model = tokens[1];
                double amountOfKm = double.Parse(tokens[2]);

                cars[model].Drive(cars[model],amountOfKm);

                input = Console.ReadLine();
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Value.model} {car.Value.fuelAmount:f2} {car.Value.distanceTraveled}");
            }
        }
    }
}
