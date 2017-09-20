using System;

namespace Stop
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.Write(new string('.', num + 1));
            Console.Write(new string('_', num * 2 + 1));
            Console.WriteLine(new string('.', num + 1));
            int lines = (num * 2 - 3) * 2 + 5;

            for (int i = 0; i < num; i++)
            {
                Console.Write(new string('.', num - i));
                Console.Write(@"//");
                Console.Write(new string('_', (num * 2 - 1) + i * 2));
                Console.Write(@"\\");
                Console.Write(new string('.', num - i));
                Console.WriteLine();
            }
            Console.Write("//");
            Console.Write(new string('_', num * 2 - 3));
            Console.Write("STOP!");
            Console.Write(new string('_', num * 2 - 3));
            Console.WriteLine(@"\\");

            for (int i = 0; i < num; i++)
            {
                Console.Write(new string('.', i));
                Console.Write(@"\\");
                Console.Write(new string('_', lines - i * 2));
                Console.Write(@"//");
                Console.Write(new string('.', i));
                Console.WriteLine();
            }
        }
    }
}