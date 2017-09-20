using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            string separator = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            List<string> allWords = new List<string>();

            for (int i = 0; i < num; i++)
            {
                string word = Console.ReadLine();
                allWords.Add(word);
            }
            Console.WriteLine(string.Join(separator,allWords));
        

        }
    }
}
