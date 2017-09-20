using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = Console.ReadLine().Split('|').ToList();
            list.Reverse();
            
            List<string> result = new List<string>();
            foreach (var item in list)
            {
                List<string> temp = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(temp);
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
