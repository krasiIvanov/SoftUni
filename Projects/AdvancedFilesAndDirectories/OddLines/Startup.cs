using BashSoft;
using System.IO;

namespace OddLines
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            string outputPath = @"C:\Users\Krasimir\Desktop\files and directories\ResoultOutput\MyOutputh.txt";
            string input = @"C:\Users\Krasimir\Desktop\files and directories\02_OddLines\01_OddLinesIn.txt";
            string expectedOutput = @"C:\Users\Krasimir\Desktop\files and directories\02_OddLines\01_OddLinesOut.txt";

            var reader = File.OpenText(input);
            var writer = File.AppendText(outputPath);

            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadLine();
                    int counter = 0;
                    while (line != null)
                    {
                        if (counter % 2 != 0)
                        {
                            writer.WriteLine(line);
                        }
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
            Tester.CompereContent(outputPath, expectedOutput);
            File.Delete(outputPath);
        }
    }
}