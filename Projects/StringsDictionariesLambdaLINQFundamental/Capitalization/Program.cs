using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalization
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            Console.WriteLine(myTI.ToTitleCase(text));

        }
    }
}
