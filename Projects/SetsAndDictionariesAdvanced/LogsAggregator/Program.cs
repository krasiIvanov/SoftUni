using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            Dictionary<string, int> totalTime = new Dictionary<string, int>();
            SortedDictionary<string, SortedSet<string>> result=new SortedDictionary<string, SortedSet<string>>();

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(' ');
                string ip = tokens[0];
                string name = tokens[1];
                int time = int.Parse(tokens[2]);
                SortedSet<string> tempSet = new SortedSet<string>();
                

                if (!result.ContainsKey(name))
                {
                    tempSet.Add(ip);
                    result.Add(name, tempSet);
                }
                else
                {
                    result[name].Add(ip);
                }

                if (!totalTime.ContainsKey(name))
                {
                    totalTime.Add(name, time);
                }
                else
                {
                    totalTime[name] += time;
                }
            }
            foreach (var item in result.Keys)
            {
                Console.WriteLine($"{item}: {totalTime[item]} [{string.Join(", ",result[item])}]");
            }
        }
    }
}
