using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindroms
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
            string[] textArr = text.Split(new char[] { ',', '.', '?', ' ', '!', ':', ' ' },StringSplitOptions.RemoveEmptyEntries);
            var result = new List<string>();
            foreach (var item in textArr)

            {
                string reverese = RevString(item);
                if (item==reverese)
                {
                    result.Add(item);
                }    
            }
            result.Sort();
            Console.WriteLine(string.Join(", ",result.Distinct()));
           

        }
        public static string RevString(string txt)
        {
            char[] str = txt.ToCharArray();
            Array.Reverse(str);

            return new string(str);
        }
    }
}
