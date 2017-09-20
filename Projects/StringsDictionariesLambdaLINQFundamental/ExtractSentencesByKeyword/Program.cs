using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine();
            
            List<string> text = Console.ReadLine().Split(new char[] {'!','.','?'}).ToList();

            foreach (var item in text)
            {
                List<string> words =item.Split(' ').ToList();

                foreach (var w in words)
                {
                    if (w=="to")
                    {
                        Console.WriteLine(item.Trim());
                    }
                }
                
            }



        }
    }
}
