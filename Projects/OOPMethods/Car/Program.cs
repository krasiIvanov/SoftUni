using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split(' ');

            int speed = int.Parse(carInfo[0]);
            double fuel = double.Parse(carInfo[1]);
            int fuelEconomy = int.Parse(carInfo[2]);

            Car car = new Car(speed,fuel,fuelEconomy);

            string input = Console.ReadLine();

            while (input!="END")
            {

                string[] tokens = input.Split(' ');
                string command = tokens[0];

                switch (command)
                {
                    case "Travel":
                        double distance = double.Parse(tokens[1]);
                        car.Travel(distance);
                        break;
                    case "Refuel":
                        double newFuel = double.Parse(tokens[1]);
                        car.Refuel(newFuel);
                        break;
                    case "Distance":
                        Console.WriteLine($"Total distance: {car.Distance():F2} kilometers");
                            break;
                    case "Fuel":
                        Console.WriteLine($"Fuel left: {car.Fuel():F2} liters");
                        break;
                    case "Time":

                        double time = car.Time();
                        Console.WriteLine($"Total time: {(int)time/60} hours and {time%60} minutes");
                        break;

                    default:
                        Console.WriteLine("Wrong comand");
                        break;
                }

                input = Console.ReadLine();
            }

        }
    }
}
