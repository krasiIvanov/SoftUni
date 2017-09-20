using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < num; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                string model = tokens[0];

                int engineSpeed = int.Parse(tokens[1]);
                int enginePower = int.Parse(tokens[2]);
                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(tokens[3]);
                string cargoType = tokens[4];
                Cargo cargo = new Cargo(cargoWeight,cargoType);

                Car car = new Car(model, engine, cargo);

                double tire1Pressure = double.Parse(tokens[5]);
                int tire1Age = int.Parse(tokens[6]);
                Tire tire1 = new Tire(tire1Pressure, tire1Age);
                car.AddTire(tire1);

                double tire2Pressure = double.Parse(tokens[7]);
                int tire2Age = int.Parse(tokens[8]);
                Tire tire2 = new Tire(tire2Pressure, tire2Age);
                car.AddTire(tire2);

                double tire3Pressure = double.Parse(tokens[9]);
                int tire3Age = int.Parse(tokens[10]);
                Tire tire3 = new Tire(tire3Pressure, tire3Age);
                car.AddTire(tire3);

                double tire4Pressure = double.Parse(tokens[11]);
                int tire4Age = int.Parse(tokens[12]);
                Tire tire4 = new Tire(tire4Pressure, tire4Age);
                car.AddTire(tire4);

                cars.Add(car);

            }

            string cmd = Console.ReadLine();

            

            if (cmd== "fragile")
            {
                var result = cars.Where(c => c.Cargo.CargoType == "fragile" && c.Tires.Any(t=>t.TirePressure<1)).ToList();
                foreach (var car in result)
                {
                    Console.WriteLine(car.Model);
                }

            }
            else
            {
                var result = cars.Where(c => c.Cargo.CargoType == "flamable" && c.Engine.EnginePower > 250).ToList();
                foreach (var car in result)
                {
                    Console.WriteLine(car.Model);
                }
            }

        }
    }
}
