using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = Console.ReadLine().ToLower().Split(' ');

            var counts = new Dictionary<string, int>();

            foreach (var w in words)
            {
                if (counts.ContainsKey(w))
                {
                    counts[w]++;
                }
                else
                {
                    counts[w] = 1;
                }
            }
            List<string> result = new List<string>();
            foreach (var item in counts.Keys)
            {
                if (counts[item]%2!=0)
                {
                    result.Add(item);
                }
            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
