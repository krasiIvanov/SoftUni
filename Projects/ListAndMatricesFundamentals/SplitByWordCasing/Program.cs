using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators= ",;:.!()\"'\\/[] ".ToArray();
            

            List<string> text = Console.ReadLine().Split(separators,StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowerCase = new List<string>();
            List<string> midCase = new List<string>();
            List<string> upperCase = new List<string>();
            foreach (var item in text)
            {

                int countLow = 0;
                int countUpper = 0;
                for (int i = 0; i < item.Length; i++)
                {
                    if (item[i]>='a'&& item[i] <='z')
                    {
                        countLow++;
                    }
                    else if (item[i] >= 'A' && item[i] <= 'Z')
                    {
                        countUpper++;
                    }
                    
                }
                if (countLow==item.Length)
                {
                    lowerCase.Add(item);
                }
                else if (countUpper==item.Length)
                {
                    upperCase.Add(item);
                }
                else
                {
                    midCase.Add(item);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ",lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", midCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");

        }
    }
}
