using System;

namespace StringLength
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.Length > 20)
            {
                string result = input.Substring(0, 20);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(input.PadRight(20, '*'));
            }
        }
    }
}