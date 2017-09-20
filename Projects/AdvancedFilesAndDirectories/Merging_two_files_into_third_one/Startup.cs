using BashSoft;
using System;
using System.Collections.Generic;
using System.IO;

namespace Merging_two_files_into_third_one
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            string input1Path = @"C:\Users\Krasimir\Desktop\files and directories\05_MergingFiles\01_FileOne.txt";
            string input2Path = @"C:\Users\Krasimir\Desktop\files and directories\05_MergingFiles\01_FileTwo.txt";
            string expectedOut = @"C:\Users\Krasimir\Desktop\files and directories\05_MergingFiles\01_Merged.txt";
            string myOutput = @"C:\Users\Krasimir\Desktop\files and directories\ResoultOutput\MyOutput.txt";

            string[] input1Lines = File.ReadAllLines(input1Path);
            string[] input2Lines = File.ReadAllLines(input2Path);

            int max = Math.Max(input1Lines.Length, input2Lines.Length);

            List<string> result = new List<string>();

            using (var writer = File.AppendText(myOutput))
            {
                for (int i = 0; i < max; i++)
                {
                    if (i < input1Lines.Length)
                    {
                        writer.WriteLine(input1Lines[i]);
                    }

                    if (i < input2Lines.Length)
                    {
                        writer.WriteLine(input2Lines[i]);
                    }
                }
            }

            Tester.CompereContent(myOutput, expectedOut);
            File.Delete(myOutput);
        }
    }
}