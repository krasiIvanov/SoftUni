using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OccurrencesInString
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();

            int startPos = 0;
            int count = 0;
            while (true)
            {
                int pos =text.IndexOf(word, startPos);
                if (pos==-1)
                {
                    break;
                }
                count++;
                startPos = pos+1;
            }

        }
    }
}
