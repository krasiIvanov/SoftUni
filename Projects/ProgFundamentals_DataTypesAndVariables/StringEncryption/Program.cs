using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string result = String.Empty;
            for (int i = 0; i < num; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                string encryptedChar = Encrypt(currentChar);
                result += encryptedChar;
            }
            Console.WriteLine(result);
        }

        public static string Encrypt(char letter)
        {
            string result = String.Empty;
            int code = letter;

            char[] digits = code.ToString().ToCharArray();
            char firstDigit = digits.First();
            char lastDigit = digits.Last();

            int lastToInt = int.Parse(lastDigit.ToString());
            int firstToInt = int.Parse(firstDigit.ToString());

            char startChar = (char)(code + lastToInt);
            char endChar = (char)(code - firstToInt);
            result = $"{startChar}{firstDigit}{lastDigit}{endChar}";
            return result;
        }
    }
}
