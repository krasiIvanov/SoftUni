using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {

            int numOfEngines = int.Parse(Console.ReadLine());
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numOfEngines; i++)
            {
                string[] engineTokens = Console.ReadLine().Split();

                string model = engineTokens[0];
                int power = int.Parse(engineTokens[1]);

                Engine newEngine;
                string efficiency;
                int displacement;
                if (engineTokens.Count() == 3)
                {
                    
                    if (int.TryParse(engineTokens[2],out displacement))
                    {
                         newEngine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        efficiency = engineTokens[2];
                        newEngine = new Engine(model, power, efficiency);
                    }
                }
                else if (engineTokens.Count() == 2)
                {
                    newEngine = new Engine(model, power);
                }
                else
                {
                    displacement = int.Parse(engineTokens[2]);
                    efficiency = engineTokens[3];

                    newEngine = new Engine(model, power, displacement, efficiency);
                }

                engines.Add(model, newEngine);

            }

            int numOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCars; i++)
            {
                string[] carTokens = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);

                Car newCar;

                string model = carTokens[0];
                Engine engine = engines[carTokens[1]];
                int weight;
                string color;

                if (carTokens.Count()==3)
                {
                    if (int.TryParse(carTokens[2],out weight))
                    {
                        newCar = new Car(model, engine, weight);
                    }
                    else
                    {
                        color = carTokens[2];
                        newCar = new Car(model, engine, color);
                    }
                }
                else if (carTokens.Count()==2)
                {
                    newCar = new Car(model, engine);
                }
                else
                {
                    weight = int.Parse(carTokens[2]);
                    color = carTokens[3];

                    newCar = new Car(model, engine, weight, color);
                }

                cars.Add(newCar);

            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

        }
    }
}
