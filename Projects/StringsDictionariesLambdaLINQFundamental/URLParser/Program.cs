using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();
            int firstSeparator = url.IndexOf("://");
            string protocol = url.Substring(0, firstSeparator);
            int secondSeparator = url.IndexOf("/", firstSeparator+3);
            string server = url.Substring(firstSeparator + 3, secondSeparator-firstSeparator-3);
            string resource = url.Substring(secondSeparator + 1);
            Console.WriteLine(protocol);
            Console.WriteLine(server);
            Console.WriteLine(resource);
            
        }
    }
}
