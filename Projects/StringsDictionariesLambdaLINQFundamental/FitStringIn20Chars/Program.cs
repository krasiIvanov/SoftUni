using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitStringIn20Chars
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            if (text.Length>=20)
            {
                Console.WriteLine(text.Substring(0,20));
            }
            else
            {
                Console.WriteLine(text.PadRight(20,'*'));
            }

        }
    }
}
