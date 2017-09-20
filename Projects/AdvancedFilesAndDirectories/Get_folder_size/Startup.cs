using System;
using System.IO;

namespace Get_folder_size
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            string directoriPath = @"C:\Users\Krasimir\Desktop\files and directories\TestFolder";

            double totalSize = 0;

            string[] files = Directory.GetFiles(directoriPath, "*.*", SearchOption.TopDirectoryOnly);
            foreach (var item in files)
            {
                FileInfo info = new FileInfo(item);
                totalSize += info.Length;
            }
            double result = (totalSize / 1024) / 1024;
            Console.WriteLine(result);
        }
    }
}