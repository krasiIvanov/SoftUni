using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParentheses
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            //75/100

            char[] simvols = Console.ReadLine().ToCharArray();
            Queue<char> charQueue = new Queue<char>(simvols);
            Stack<char> charStack = new Stack<char>(simvols);
            bool flag = false;

            char[] type1 = new char[] { '{', '}' };
            char[] type2 = new char[] { '[', ']' };
            char[] type3 = new char[] { '(', ')' };

            for (int i = 0; i < simvols.Length / 2; i++)
            {
                char queueFirstChar = charQueue.Dequeue();
                char stackFirstChar = charStack.Pop();
                if (
                    (type1.Contains(queueFirstChar) && type1.Contains(stackFirstChar)) ||
                    (type2.Contains(queueFirstChar) && type2.Contains(stackFirstChar)) ||
                    (type3.Contains(queueFirstChar) && type3.Contains(stackFirstChar))
                   )
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            if (flag)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}