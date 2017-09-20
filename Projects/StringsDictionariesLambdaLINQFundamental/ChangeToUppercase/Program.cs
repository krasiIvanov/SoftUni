using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeToUppercase
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "Welcome to the <upcase>Software University</upcase>. Learn <upcase>computer programming</upcase> and start a <upcase>job</upcase> in a software company.";

            List<string> output = new List<string>();
            int a = 0;
            int b = 0;
            while (a != -1 && b != -1)
            {
                a = input.IndexOf("<upcase>");
                b = input.IndexOf("</upcase>");
                if (a != -1)
                {
                    string text = input.Substring(0, a);
                    output.Add(text);
                    string text1 = input.Substring(a + 8, b - (a + 8)).ToUpper();
                    output.Add(text1);
                    input = input.Substring(b + 9, input.Length - (b + 9));
                }
                else
                {
                    string text = input.Substring(0, input.Length);
                    output.Add(text);
                }
            }
            Console.WriteLine(string.Join("", output));

        }
    }
}
