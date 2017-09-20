using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLast
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] carTokens = Console.ReadLine().Split();
            double carQuantity = double.Parse(carTokens[1]);
            double carConsumption = double.Parse(carTokens[2]);
            double carTankCapacity= double.Parse(carTokens[3]);
            Vehicle car = new Car(carQuantity, carConsumption,carTankCapacity);

            string[] truckTokens = Console.ReadLine().Split();
            double truckQuantity = double.Parse(truckTokens[1]);
            double truckConsumption = double.Parse(truckTokens[2]);
            double truckTankCapacity = double.Parse(truckTokens[3]);
            Vehicle truck = new Truck(truckQuantity, truckConsumption,truckTankCapacity);

            string[] busTokens = Console.ReadLine().Split();
            double busQuantity = double.Parse(busTokens[1]);
            double busConsumption = double.Parse(busTokens[2]);
            double busTankCapacity = double.Parse(busTokens[3]);
            Vehicle bus = new Bus(busQuantity, busConsumption, busTankCapacity);

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split();
                string cmd = input[0];
                string vehicle = input[1];
                double fuelOrDistance = double.Parse(input[2]);

                if (vehicle=="Car")
                {
                    Execute(car, cmd, fuelOrDistance);
                }
                else if (vehicle=="Bus")
                {
                    
                    Execute(bus, cmd, fuelOrDistance);
                }
                else
                {
                    Execute(truck, cmd, fuelOrDistance);
                }

            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);

        }

        public static void Execute(Vehicle vehicle,string cmd,double fuelOrDistance)
        {
            try
            {
                switch (cmd)
                {

                    case "Drive":
                        vehicle.Drive(fuelOrDistance);

                        break;
                    case "Refuel":
                        vehicle.Refueling(fuelOrDistance);
                        break;
                    case "DriveEmpty":
                        vehicle.Drive(fuelOrDistance, true);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            

        }
    }
}
