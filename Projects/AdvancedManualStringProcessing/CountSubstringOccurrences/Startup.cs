using System;

namespace CountSubstringOccurrences
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string word = Console.ReadLine();

            int counter = 0;
            int index = text.IndexOf(word);

            while (index != -1)
            {
                counter++;
                index = text.IndexOf(word, index + 1);
            }
            Console.WriteLine(counter);
        }
    }
}