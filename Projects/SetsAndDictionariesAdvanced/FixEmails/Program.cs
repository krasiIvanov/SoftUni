using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> namesAndEmails = new Dictionary<string, string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="stop")
                {
                    break;
                }
                string email = Console.ReadLine();
               
                if (!namesAndEmails.ContainsKey(input))
                {
                    namesAndEmails.Add(input, email);
                }
                else
                {
                    namesAndEmails[input] = email;
                }
                
            }

            foreach (var item in namesAndEmails)
            {
                string[] emailCheck = item.Value.Split('.');
                string domain = emailCheck[emailCheck.Length - 1];
                if (domain!="us"&&domain!="uk")
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
        }
    }
}
