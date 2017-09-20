using System;

namespace Problem1
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double o = double.Parse(Console.ReadLine());

            double squere = n * n;
            double squereM = m * o;
            double squereWL = w * l;

            double total = (squere - squereM) / squereWL;
            double time = total * 0.2;

            Console.WriteLine(total);
            Console.WriteLine(time);
        }
    }
}