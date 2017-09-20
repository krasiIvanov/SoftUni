using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendList
{
    class Program
    {
        static void Main(string[] args)
        {

            var lists = Console.ReadLine().Split('|').ToList();

            lists.Reverse();
            Console.WriteLine(string.Join(" ",lists));

            for (int i = 0; i < lists.Count; i++)
            {
                var tempList = lists[i].Split(' ');
                foreach (var item in tempList)
                {
                    if (item != "")
                    {
                        Console.Write(item + " ");
                    }

                }
            }


        }
    }
}
