using System;
using System.IO;

namespace BashSoft
{
    public static class Tester
    {
        public static void CompereContent(string userOutputPath, string expectedOutputPath)
        {
            try
            {
                OutputWriter.WriteMessegesOnNewLine("Reading files...");

                string mismatchPath = GetMismatchPath(expectedOutputPath);

                string[] actualOutPutLines = File.ReadAllLines(userOutputPath);
                string[] expectedOutputLines = File.ReadAllLines(expectedOutputPath);

                bool hasMismatch;

                string[] mismatches = GetLinesWithPossibleMismatches(actualOutPutLines, expectedOutputLines, out hasMismatch);

                PrintOutput(mismatches, hasMismatch, mismatchPath);
                OutputWriter.WriteMessegesOnNewLine("Files read!");
            }
            catch (FileNotFoundException)
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidPath);
            }
        }

        private static void PrintOutput(string[] mismatches, bool hasMismatch, string mismatchPath)
        {
            if (hasMismatch)
            {
                foreach (var item in mismatches)
                {
                    OutputWriter.WriteMessegesOnNewLine(item);
                }
                try
                {
                    File.WriteAllLines(mismatchPath, mismatches);
                }
                catch (DirectoryNotFoundException)
                {
                    OutputWriter.DisplayException(ExceptionMessages.InvalidPath);
                }

                return;
            }
            OutputWriter.WriteMessegesOnNewLine("Files are identical. There are no mismatches");
        }

        private static string[] GetLinesWithPossibleMismatches(string[] actualOutPutLines, string[] expectedOutputLines, out bool hasMismatch)
        {
            hasMismatch = false;
            string output = string.Empty;

            OutputWriter.WriteMessegesOnNewLine("Comparing files...");

            int minOutputLines = actualOutPutLines.Length;
            if (actualOutPutLines.Length != expectedOutputLines.Length)
            {
                hasMismatch = true;
                minOutputLines = Math.Min(actualOutPutLines.Length, expectedOutputLines.Length);
                OutputWriter.DisplayException(ExceptionMessages.ComparisonOfFilesWithDifferentSizes);
            }
            string[] mismatches = new string[minOutputLines];

            for (int i = 0; i < minOutputLines; i++)
            {
                string actualLine = actualOutPutLines[i];
                string expectedLines = expectedOutputLines[i];
                if (!actualLine.Equals(expectedLines))
                {
                    output = string.Format("Mismatch at line {0} -- expected \"{1}\", actual:\"{2}\" ", i, expectedLines, actualLine);
                    output += Environment.NewLine;
                    hasMismatch = true;
                }
                else
                {
                    output = actualLine;
                    output += Environment.NewLine;
                }
                mismatches[i] = output;
            }
            return mismatches;
        }

        private static string GetMismatchPath(string expectedOutputhPat)
        {
            int indexOf = expectedOutputhPat.LastIndexOf('\\');
            string directoryPath = expectedOutputhPat.Substring(0, indexOf);
            string finalPath = directoryPath + @"\Mismatch.txt";
            return finalPath;
        }
    }
}