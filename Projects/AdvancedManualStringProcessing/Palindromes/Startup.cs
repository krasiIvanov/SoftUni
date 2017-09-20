using System;
using System.Collections.Generic;

namespace Palindromes
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',', '/', '\\', '.', '!', '?', '(', ')', '\'', '"' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> result = new List<string>();

            foreach (var item in input)
            {
                bool ispalindrome = true;
                for (int i = 0; i < item.Length / 2; i++)
                {
                    if (item[i] != item[item.Length - i - 1])
                    {
                        ispalindrome = false;
                    }
                }
                if (ispalindrome)
                {
                    result.Add(item);
                }
            }
        }
    }
}