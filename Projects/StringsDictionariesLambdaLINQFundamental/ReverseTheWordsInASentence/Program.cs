using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTheWordsInASentence
{
    class Program
    {
        static void Main(string[] args)
        {
            var separators = ".,:;=()&[]\"'\\/!? ".ToCharArray();
            string text = Console.ReadLine();

            var textArr = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
           
            var signs = text.Split(textArr, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(textArr);

            for (int i = 0; i < textArr.Length; i++)
            {
                Console.Write(textArr[i]+signs[i]);
            }
            Console.WriteLine();
     
        }
    }
}
