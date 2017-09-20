using BashSoft;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            string wordsPath = @"C:\Users\Krasimir\Desktop\files and directories\04_WordCount\words1.txt";
            string inputPath = @"C:\Users\Krasimir\Desktop\files and directories\04_WordCount\text1.txt";
            string expectedOut = @"C:\Users\Krasimir\Desktop\files and directories\04_WordCount\01_WordCountOut.txt";
            string myOutput = @"C:\Users\Krasimir\Desktop\files and directories\ResoultOutput\MyOutput.txt";

            string[] kays = File.ReadAllText(wordsPath).Split(' ');

            Dictionary<string, int> wordsCounter = new Dictionary<string, int>();
            foreach (var item in kays)
            {
                if (!wordsCounter.ContainsKey(item))
                {
                    string kay = item.ToLower();
                    wordsCounter.Add(kay, 0);
                }
            }

            string[] lines = File.ReadAllLines(inputPath);
            char[] separators = "(),\\.:;- /'\"".ToCharArray();
            for (int i = 0; i < lines.Length; i++)
            {
                string[] tempArr = lines[i].ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in tempArr)
                {
                    if (wordsCounter.ContainsKey(item))
                    {
                        wordsCounter[item]++;
                    }
                }
            }
            using (var writer = File.AppendText(myOutput))
            {
                foreach (var item in wordsCounter.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key))
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }
            }

            Tester.CompereContent(myOutput, expectedOut);
            File.Delete(myOutput);
        }
    }
}