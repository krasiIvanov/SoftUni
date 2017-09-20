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

            int enginesNumber = int.Parse(Console.ReadLine());
            char[] effType = new char[] { 'A', 'B', 'C','D','F' };
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            for (int i = 0; i < enginesNumber; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(' ');

                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);
                Engine newEngine = new Engine(model, power);
                string efficency;
                string displacment;
                if (engineInfo.Count()>2)
                {
                    if (effType.Contains(engineInfo[2][0]))
                    {
                        efficency = engineInfo[2];
                        newEngine.efficency = efficency;
                    }
                    else
                    {
                        displacment = engineInfo[2];
                        newEngine.displacement = displacment;
                    }

                }
                if (engineInfo.Count()>3)
                {
                    
                    efficency = engineInfo[3];
                    newEngine.efficency = efficency;
                }
                engines.Add(newEngine);
                
                
            }
            int carsNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < carsNumber; i++)
            {
                string[] carInfo = Console.ReadLine().Split(' ');
                string model = carInfo[0];
                Engine engine = engines.First(e=>e.model==carInfo[1]);
                Car newCar = new Car(model, engine);
                int weight = 0;
                if (carInfo.Count() > 2)
                {
                    if (int.TryParse(carInfo[2], out weight))
                    {
                        newCar.weight = carInfo[2];
                    }
                    else
                    {
                        newCar.color = carInfo[2];
                    }
                    
                }
                
                if (carInfo.Count() > 3)
                {

                    newCar.color = carInfo[3];
                }
                cars.Add(newCar);
            }
            foreach (var item in cars)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
