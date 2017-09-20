using System;
using System.IO;

namespace Read_from_specified_line
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            //select directory
            string inputPath = @"C:\Users\Krasimir\Desktop\files and directories\04_WordCount\text1.txt";

            string[] allLines = File.ReadAllLines(inputPath);

            for (int i = num; i < allLines.Length; i++)
            {
                Console.WriteLine(allLines[i]);
            }
        }
    }
}