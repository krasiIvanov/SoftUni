using System;

namespace FormattingNumbers
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int a = int.Parse(input[0]);
            double b = double.Parse(input[1]);
            double c = double.Parse(input[2]);

            string hexa = a.ToString("X");
            string binary = Convert.ToString(a, 2);

            Console.WriteLine("|{0}|{1}|{2:d2}|{3:3d}|", hexa.PadRight(10), binary.PadLeft(10, '0').Substring(0, 10), b.ToString("0.00").PadLeft(10), c.ToString("0.000").PadRight(10));
        }
    }
}