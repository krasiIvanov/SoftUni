using System;
using System.Collections.Generic;

namespace CalculateSequenceWithQueue
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            Queue<long> numbers = new Queue<long>();
            numbers.Enqueue(num);
            List<long> result = new List<long>();
            result.Add(num);

            while (result.Count < 50)
            {
                long firstOfQueue = numbers.Dequeue();

                long seq1 = firstOfQueue + 1;
                numbers.Enqueue(seq1);
                result.Add(seq1);
                if (result.Count == 50) break;

                long seq2 = 2 * firstOfQueue + 1;
                numbers.Enqueue(seq2);
                result.Add(seq2);
                if (result.Count == 50) break;

                long seq3 = firstOfQueue + 2;
                numbers.Enqueue(seq3);
                result.Add(seq3);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}