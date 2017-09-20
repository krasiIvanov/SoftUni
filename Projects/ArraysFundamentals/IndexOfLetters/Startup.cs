using System;

namespace IndexOfLetters
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            string txt = Console.ReadLine();
            char[] alphabet = new char[26];
            char later = 'a';
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = later;
                later++;
            }

            for (int i = 0; i < txt.Length; i++)
            {
                int num = Array.IndexOf(alphabet, txt[i]);

                Console.WriteLine($"{txt[i]} -> {num}");
            }
        }
    }
}