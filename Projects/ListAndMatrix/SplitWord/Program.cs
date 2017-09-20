using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var lowerCase = new List<string>();
            var midleCase = new List<string>();
            var uperCase = new List<string>();
            var separators = ",;:.!()\"'/\\[] ".ToArray();

            var words = text.Split(separators);

            foreach (var item in words)
            {
                int lowerLater = 0;
                int uperLaters = 0;
                foreach (var latter in item)
                {
                    if (latter >= 'a' && latter <= 'z')
                    {
                        lowerLater++;
                    }
                    else if (latter >= 'A' && latter <= 'Z')
                    {
                        uperLaters++;
                    }
                   
                }
                if (lowerLater==item.Length)
                {
                    lowerCase.Add(item);
                }
                else if (uperLaters == item.Length)
                {
                    uperCase.Add(item);
                }
                else
                {
                    midleCase.Add(item);
                }
            }

            Console.WriteLine("LowerCase: "+string.Join(" ",lowerCase));
            Console.WriteLine("MidleCase: " + string.Join(" ", midleCase));
            Console.WriteLine("UpperCase: " + string.Join(" ", uperCase));
        }
    }
}
