using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedDictionary<string, Dictionary<string,int>> namesAndIP = new SortedDictionary<string, Dictionary<string,int>>();
            
            while (true)
            {
                string input = Console.ReadLine();

                if (input=="end")
                {
                    break;
                }

                string[] parseString = input.Split(new char[] {' ', '=', '\'' }, StringSplitOptions.RemoveEmptyEntries);
                string ip = parseString[1];
                string username = parseString[parseString.Length-1];
                Dictionary<string, int> tempDictionary = new Dictionary<string, int>();
                tempDictionary.Add(ip, 1);
                
                if (!namesAndIP.ContainsKey(username))
                {
                    namesAndIP.Add(username, tempDictionary);
                }
                else
                {
                    if (!namesAndIP[username].ContainsKey(ip))
                    {
                        namesAndIP[username].Add(ip, 1);
                    }
                    else
                    {
                        namesAndIP[username][ip]++;
                    }
                }
            }
            foreach (var username in namesAndIP.Keys)
            {
                int count = 0;
                Console.WriteLine($"{username}: ");
                foreach (var ip in namesAndIP[username])
                {
                    if (count==namesAndIP[username].Count-1)
                    {
                        Console.WriteLine($"{ip.Key} => {ip.Value}.");
                    }
                    else
                    {
                        Console.Write($"{ip.Key} => {ip.Value}, ");
                        count++;
                    }
                    
                }

            }

        }
    }
}
