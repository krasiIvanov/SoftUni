using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < num; i++)
            {
                string[] carTokens = Console.ReadLine().Split();
                string model = carTokens[0];
                double fuelAmount = double.Parse(carTokens[1]);
                double fuelConsumption = double.Parse(carTokens[2]);
                Car newCar=new Car(model,fuelAmount,fuelConsumption);

                cars.Add(newCar);
            }

            string comand = Console.ReadLine();

            while (comand !="End")
            {
                string[] inputTokens = comand.Split();

                string model = inputTokens[1];
                int distance = int.Parse(inputTokens[2]);

                Car currentCar = cars.Where(c => c.Model == model).FirstOrDefault();

                currentCar.Drive(distance);

                comand = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

        }
    }
}
