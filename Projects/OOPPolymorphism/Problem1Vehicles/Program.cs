using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] carInfo = Console.ReadLine().Split(' ');
            double carFuelQuantity = double.Parse(carInfo[1]);
            double carFuelPerKm = double.Parse(carInfo[2]);
            double carTankCapacity=double.Parse(carInfo[3]);
            Car car = new Car(carFuelQuantity, carFuelPerKm, carTankCapacity);

            string[] truckInfo = Console.ReadLine().Split(' ');
            double trucFuelQuantity = double.Parse(truckInfo[1]);
            double trucFuelPerKm = double.Parse(truckInfo[2]);
            double trucTankCapacity = double.Parse(truckInfo[3]);

            Truck truck = new Truck(trucFuelQuantity, trucFuelPerKm,trucTankCapacity);

            string[] busInfo = Console.ReadLine().Split(' ');
            double busFuelQuantity = double.Parse(busInfo[1]);
            double busFuelPerKm = double.Parse(busInfo[2]);
            double busTankCapacity = double.Parse(busInfo[3]);

            Bus bus = new Bus(busFuelQuantity, busFuelPerKm, busTankCapacity);

            int numberOfCmd = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCmd; i++)
            {
                string[] operation = Console.ReadLine().Split(' ');
                string type = operation[1];
                string cmd = operation[0];
                double value =double.Parse(operation[2]);

                try
                {
                    if (cmd == "Drive")
                    {

                        if (type == "Car")
                        {
                            car.Drive(value);
                        }
                        else if (type == "Truck")
                        {
                            truck.Drive(value);
                        }
                        else
                        {
                            bus.Drive(value);
                        }


                    }
                    else if (cmd == "Refuel")
                    {
                        if (type == "Car")
                        {
                            car.Refuel(value);
                        }
                        else if (type == "Truck")
                        {
                            truck.Refuel(value);
                        }
                        else
                        {
                            bus.Refuel(value);
                        }
                    }
                    else
                    {
                        bus.DriveEmpty(value);
                    }
                }
                catch (InvalidOperationException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);


        }
    }
}
