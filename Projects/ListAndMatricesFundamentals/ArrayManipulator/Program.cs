using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> resultList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            

            while (true)
            {
                string[] stringComands = Console.ReadLine().Split(' ');
                if (stringComands[0]=="print")
                {
                    break;

                }
                string command = stringComands[0];
                List<int> items = new List<int>();
                for (int i = 1; i < stringComands.Length; i++)
                {
                    int tempNum = int.Parse(stringComands[i]);
                    items.Add(tempNum);
                }
                switch (command)
                {
                    case "add":
                        resultList = AddOperation(resultList,items);
                        break;
                    case "addMany":
                        resultList = AddManyOperation(resultList, items);
                        break;
                    case "contains":
                        ContainsOperation(resultList,items);
                        break;
                    case "remove":
                        resultList = RemoveOperation(resultList, items);
                        break;
                    case "shift":
                        resultList = ShiftOperation(resultList, items);
                        break;
                    case "sumPairs":resultList= SumPairsOperation(resultList);
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine(string.Join(" ",resultList));

        }

        private static List<int> SumPairsOperation(List<int> resultList)
        {
            List<int> result = new List<int>();
            int lastPos = resultList.Count - 1;
            for (int i = 0; i < resultList.Count-1; i++)
            {
                int sum = resultList[i] + resultList[i + 1];
                result.Add(sum);
                i++;
            }
            if (resultList.Count%2!=0)
            {
                result.Insert(result.Count, resultList[lastPos]);
            }
            
            
            return result;
        }

        private static List<int> ShiftOperation(List<int> resultList, List<int> items)
        {
            int pos = items[0];

            for (int i = 0; i < pos; i++)
            {
                int lastNum = resultList.Last();
                int lastIndex = resultList.Count-1;
                resultList.RemoveAt(lastIndex);
                resultList.Insert(0, lastNum);
            }
            return resultList;
        }

        private static List<int> RemoveOperation(List<int> resultList, List<int> items)
        {
            int index = items[0];
            resultList.RemoveAt(index);

            return resultList;
        }

        private static void ContainsOperation(List<int> resultList, List<int> items)
        {
            int num = items[0];

            Console.WriteLine(resultList.IndexOf(num)); 
        }

        private static List<int> AddManyOperation(List<int> resultList, List<int> items)
        {
            int index = items[0];
            items.RemoveAt(0);
            resultList.InsertRange(index, items);

            return resultList;
        }

        private static List<int> AddOperation(List<int> resultList, List<int> items)
        {

            int index = items[0];
            int num = items[1];
            resultList.Insert(index, num);
            
            return resultList;
        }
    }
}
