using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, long> miner = new Dictionary<string, long>();
            List<string> tokens = new List<string>();
            tokens.Add("");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower()=="stop")
                {
                    break;
                }

                tokens.Add(input);
            }
            string privElement = "";
            for (int i = 1; i < tokens.Count; i++)
            {
                
                if (i % 2 != 0)
                {
                    privElement = tokens[i];
                    if (!miner.ContainsKey(tokens[i]))
                    {
                        miner.Add(tokens[i], 0);
                    }
                }
                else
                {
                    miner[privElement] += long.Parse(tokens[i]);
                }
            }

            foreach (var item in miner)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
