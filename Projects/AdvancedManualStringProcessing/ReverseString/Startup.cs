using System;

namespace ReverseString
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputToChar = input.ToCharArray();
            Array.Reverse(inputToChar);
            Console.WriteLine(string.Join("", inputToChar));
        }
    }
}