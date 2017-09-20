using BashSoft;
using System.IO;

namespace LineNumbers
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            string outputPath = @"C:\Users\Krasimir\Desktop\files and directories\ResoultOutput\MyOutputh.txt";
            string input = @"C:\Users\Krasimir\Desktop\files and directories\03_LineNumbers\01_LinesIn.txt";
            string expectedOutput = @"C:\Users\Krasimir\Desktop\files and directories\03_LineNumbers\01_LinesOut.txt";

            string[] lines = File.ReadAllLines(input);

            using (var writer = File.AppendText(outputPath))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    writer.WriteLine($"{i + 1}. {lines[i]}");
                }
            }

            Tester.CompereContent(outputPath, expectedOutput);
            File.Delete(outputPath);
        }
    }
}