using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbiddenSubstrings
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            string[]occurrence = Console.ReadLine().Split(' ');
            
            foreach (var item in occurrence)
            {
                text = text.Replace(item, new string('*', item.Length));
            }
            Console.WriteLine(text);
        }
    }
}
