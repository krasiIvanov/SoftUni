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
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="search")
                {
                    break;
                }
                string[] tokens = input.Split('-');
                string name = tokens[0];
                string phoneNumber = tokens[1];

                if (!phonebook.ContainsKey(name))
                {
                    phonebook.Add(name, phoneNumber);
                }
                else
                {
                    phonebook[name] = phoneNumber;

                }
            }
            while (true)
            {
                string input= Console.ReadLine();
                if (input.ToLower()=="stop")
                {
                    break;
                }

                if (phonebook.ContainsKey(input))
                {
                    Console.WriteLine($"{input} -> {phonebook[input]}");
                }
                else
                {
                    Console.WriteLine($"Contact {input} does not exist.");
                }
            }

        }
    }
}
