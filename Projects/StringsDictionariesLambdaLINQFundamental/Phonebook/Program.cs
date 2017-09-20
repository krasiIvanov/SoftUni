using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            List<string> output = new List<string>();

            while (true)
            {
                string info = Console.ReadLine();
                if (info=="END")
                {
                    break;
                }
                if (info=="ListAll")
                {
                    foreach (var item in phonebook.Keys)
                    {
                        Console.WriteLine("{0} -> {1}",item,phonebook[item]);
                    }

                }
                var infoArr = info.Split(' ');
                string command = infoArr[0];

                if (command=="A")
                {
                    if (phonebook.ContainsKey(infoArr[1]))
                    {
                        phonebook[infoArr[1]] = infoArr[2];
                    }
                    else
                    {
                        phonebook.Add(infoArr[1], infoArr[2]);
                    }
                }
                else if (command=="S")
                {
                    output.Add(infoArr[1]);
                }
            }

            foreach (var item in output)
            {
                if (phonebook.ContainsKey(item))
                {
                    Console.WriteLine("{0} -> {1}",item,phonebook[item]);
                }
                else
                {
                    Console.WriteLine("Conctact {0} does not exist.",item);
                }
            }
        }
    }
}
