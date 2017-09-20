using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallisticsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cordinats = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int x = cordinats[0];
            int y = cordinats[1];

            string[] input = Console.ReadLine().Split(' ');

            int fireX = 0;
            int fireY = 0;

            for (int i = 0; i < input.Length; i+=2)
            {
                string operation = input[i];
                int value = int.Parse(input[i + 1]);

                switch (operation)
                {
                    case "right":fireX += value;
                        break;
                    case "left":fireX -= value;
                        break;
                    case "up":fireY += value;
                        break;
                    case "down":fireY -= value;
                            break;
                    default:
                        break;
                }
                
            }
            Console.WriteLine($"firing at [{fireX}, {fireY}]");
            if (fireX == x && fireY == y)
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
