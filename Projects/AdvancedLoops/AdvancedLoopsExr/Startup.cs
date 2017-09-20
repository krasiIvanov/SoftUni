using System;

namespace AdvancedLoopsExr
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i = i * 2 + 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}