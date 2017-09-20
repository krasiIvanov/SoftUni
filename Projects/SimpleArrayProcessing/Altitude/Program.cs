using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altitude
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');

            int altitude = int.Parse(input[0]);
            bool isCrashed = false;

            for (int i = 1; i < input.Length; i+=2)
            {
                string operation = input[i];
                int value = int.Parse(input[i + 1]);

                if (operation=="up")
                {
                    altitude += value;
                }
                else
                {
                    altitude -= value;
                    if (altitude<=0)
                    {
                        Console.WriteLine("crashed");
                        isCrashed = true;
                        break;
                    }
                }
            }
            if (!isCrashed)
            {
                Console.WriteLine($"got through safely. current altitude: {altitude}m");
            }
            

        }
    }
}
