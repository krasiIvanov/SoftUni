using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountChars
{
    class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine().ToLower();
            int sum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                if (c == 'a')
                {
                    sum += 1;
                }
                else if (c == 'e')
                {
                    sum += 2;
                }
                else if (c == 'i')
                {
                    sum += 3;
                }
                else if (c == 'o')
                {
                    sum += 4;
                }
                else if (c == 'u')
                {
                    sum += 5;
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
