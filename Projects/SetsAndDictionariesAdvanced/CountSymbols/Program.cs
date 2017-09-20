using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            SortedDictionary<char, int> countSymbol = new SortedDictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (!countSymbol.ContainsKey(text[i]))
                {
                    countSymbol.Add(text[i], 1);
                }
                else
                {
                    countSymbol[text[i]]++;
                }
            }
            foreach (var item in countSymbol)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
        }
    }
}
