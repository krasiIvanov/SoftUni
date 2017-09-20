using System;

namespace Faktoriel
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int faktoriel = 1;

            for (int i = 2; i <= num; i++)
            {
                faktoriel = faktoriel * i;
            }
            Console.WriteLine(faktoriel);
        }
    }
}