using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators= ".,:;()[]\"'\\/!? ".ToCharArray();

            string[] text = Console.ReadLine().ToLower().Split(separators);
            var result = text.Distinct().OrderBy(x =>x);
            Console.WriteLine(string.Join(" ",result.Where(x =>x.Length<5)));
        }
    }
}
