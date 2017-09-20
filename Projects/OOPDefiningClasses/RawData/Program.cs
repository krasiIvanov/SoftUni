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
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];

                int speed = int.Parse(input[1]);
                int power = int.Parse(input[2]);
                Engine engine = new Engine(speed,power);

                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                double tier1Pressure = double.Parse(input[5]);
                int tier1Age = int.Parse(input[6]);
                Tier tier1 = new Tier(tier1Pressure, tier1Age);
                double tier2Pressure = double.Parse(input[7]);
                int tier2Age = int.Parse(input[8]);
                Tier tier2 = new Tier(tier2Pressure, tier2Age);
                double tier3Pressure = double.Parse(input[9]);
                int tie3rAge = int.Parse(input[10]);
                Tier tier3 = new Tier(tier3Pressure, tie3rAge);
                double tier4Pressure = double.Parse(input[11]);
                int tie4rAge = int.Parse(input[12]);
                Tier tier4 = new Tier(tier4Pressure, tie4rAge);

                Tier[] tiers = new Tier[] {tier1,tier2,tier3,tier4 };

                Car newCar = new Car(model, engine,cargo,tiers);
                cars.Add(newCar);

            }
            string command = Console.ReadLine();
            List<Car> result = new List<Car>();
            if (command=="fragile")
            {
                 result = cars.Where(c => c.cargo.cargoType == "fragile" && c.tiers.Any(t=>t.tierPressure<1)).ToList();
            }
            else 
            {
                 result = cars.Where(c => c.cargo.cargoType == "flamable" && c.engine.enginePower > 250).ToList();
            }

            foreach (var item in result)
            {
                Console.WriteLine(item.model);
            }
        }
    }
}
