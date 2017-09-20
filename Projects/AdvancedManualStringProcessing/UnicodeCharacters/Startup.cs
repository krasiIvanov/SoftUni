using System;
using System.Text;

namespace UnicodeCharacters
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            StringBuilder result = new StringBuilder();

            foreach (var item in input)
            {
                int unicodNum = item;
                string temp = unicodNum.ToString("X").PadLeft(4, '0');
                result.Append($"\\u{temp}");
            }

            Console.WriteLine(result);
        }
    }
}