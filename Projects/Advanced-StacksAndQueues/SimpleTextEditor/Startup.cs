using System;
using System.Collections.Generic;

namespace SimpleTextEditor
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string text = "";

            Stack<string> textBeforeUpdate = new Stack<string>();

            for (int i = 0; i < num; i++)
            {
                string[] info = Console.ReadLine().Split(' ');
                int operatinNum = int.Parse(info[0]);
                if (operatinNum == 1)
                {
                    textBeforeUpdate.Push(text);
                    text += info[1];
                }
                else if (operatinNum == 2)
                {
                    textBeforeUpdate.Push(text);
                    int value = int.Parse(info[1]);
                    text = text.Substring(0, text.Length - value);
                }
                else if (operatinNum == 3)
                {
                    int value = int.Parse(info[1]);
                    Console.WriteLine(text[value - 1]);
                }
                else if (operatinNum == 4)
                {
                    text = textBeforeUpdate.Pop();
                }
            }
        }
    }
}