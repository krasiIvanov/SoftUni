using System;

namespace CharacterMultiplier
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            char[] firstToken = input[0].ToCharArray();
            char[] secondToken = input[1].ToCharArray();

            int result = 0;

            if (firstToken.Length == secondToken.Length)
            {
                for (int i = 0; i < firstToken.Length; i++)
                {
                    result += firstToken[i] * secondToken[i];
                }
            }
            else
            {
                int minLenght = Math.Min(firstToken.Length, secondToken.Length);
                char[] longestArr = null;
                for (int i = 0; i < minLenght; i++)
                {
                    result += firstToken[i] * secondToken[i];
                }
                if (firstToken.Length > secondToken.Length)
                {
                    longestArr = firstToken;
                }
                else
                {
                    longestArr = secondToken;
                }
                for (int r = minLenght; r < longestArr.Length; r++)
                {
                    result += longestArr[r];
                }
            }
            Console.WriteLine(result);
        }
    }
}