using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlants
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] plants = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool isAlive = true;
            int days = 0;
            int seasons = 0;
            while (isAlive)
            {
                for (int i = 0; i < plants.Length; i++)
                {
                    for (int j = 0; j < plants.Length; j++)
                    {
                        if (j==i || plants[j]==0)
                        {
                            continue;
                        }
                        plants[j]--;
                        
                    }
                    days++;
                    if (plants.Sum()==0)
                    {
                        isAlive = false;
                        break;
                    }
                }
                if (!isAlive)
                {
                    break;
                }
                seasons++;
                for (int i = 0; i < plants.Length; i++)
                {
                    plants[i]++;
                }
            }

            Console.WriteLine($"survived {days} days ({seasons} seasons)");
        }
    }
}
