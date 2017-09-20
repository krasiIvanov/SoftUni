using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackDownloader
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] blacklistedWord = Console.ReadLine().Split();

            List<string> result = new List<string>();

            string input = Console.ReadLine();

            while (input!="end")
            {
                bool isConteinWord = false;
                for (int i = 0; i < blacklistedWord.Length; i++)
                {
                    if (input.Contains(blacklistedWord[i]))
                    {
                        isConteinWord = true;
                        break;
                    }

                }
                if (!isConteinWord)
                {
                    result.Add(input);
                }
                input = Console.ReadLine();
            }
            result.Sort();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}
