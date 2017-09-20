using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    public class GasPump
    {
        public int amountOfPump;
        public int distanceToNext;
        public int index;

        public GasPump(int amountOfPump, int distanceToNext, int index)
        {
            this.amountOfPump = amountOfPump;
            this.distanceToNext = distanceToNext;
            this.index = index;
        }
    }

    public class Startup
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Queue<GasPump> pumps = new Queue<GasPump>();

            for (int i = 0; i < num; i++)
            {
                int[] pumpsInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                GasPump newPump = new GasPump(pumpsInfo[0], pumpsInfo[1], i);
                pumps.Enqueue(newPump);
            }

            GasPump starterPump = null;
            bool flag = false;

            while (true)
            {
                GasPump currentPump = pumps.Dequeue();
                pumps.Enqueue(currentPump);
                starterPump = currentPump;

                int gasInTank = currentPump.amountOfPump;

                while (gasInTank >= currentPump.distanceToNext)
                {
                    gasInTank -= currentPump.distanceToNext;
                    currentPump = pumps.Dequeue();
                    pumps.Enqueue(currentPump);
                    if (currentPump == starterPump)
                    {
                        flag = true;
                        break;
                    }
                    gasInTank += currentPump.amountOfPump;
                }
                if (flag)
                {
                    Console.WriteLine(starterPump.index);
                    break;
                }
            }
        }
    }
}