using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIString
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 0; i < num; i++)
            {
                int charNum = int.Parse(Console.ReadLine());
                char letter = (char)charNum;
                result += letter;
            }
            Console.WriteLine(result);

        }
    }
}
