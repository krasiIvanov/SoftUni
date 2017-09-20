using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] phonenumbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');

            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            for (int i = 0; i < names.Length; i++)
            {

                phonebook.Add(names[i], phonenumbers[i]);

            }

            string input = Console.ReadLine();

            while (input!="done")
            {

                string[] tokens = input.Split(' ');

                string cmd = tokens[0];
                string value = tokens[1];

                if (cmd=="call")
                {
                    int sum=0;
                    if (phonebook.ContainsKey(value))
                    {
                        Console.WriteLine($"calling {phonebook[value]}...");
                         sum = SumOfDigits(phonebook[value]);

                    }
                    else
                    {
                        string name = phonebook.FirstOrDefault(x => x.Value == value).Key;
                        Console.WriteLine($"calling {name}...");
                        sum = SumOfDigits(value);
                    }

                    if (sum%2==0)
                    {
                        int minutes = sum / 60;
                        int seconds = sum % 60;
                        Console.WriteLine($"call ended. duration: {minutes:D2}:{seconds:D2}");
                    }
                    else
                    {
                        Console.WriteLine("no answer");
                    }

                }
                else
                {
                    int sum = 0;
                    if (phonebook.ContainsKey(value))
                    {
                        Console.WriteLine($"sending sms to {phonebook[value]}...");
                        sum = DiffOfDigits(phonebook[value]);

                    }
                    else
                    {
                        string name = phonebook.FirstOrDefault(x => x.Value == value).Key;
                        Console.WriteLine($"sending sms to {name}");
                        sum = DiffOfDigits(value);
                    }

                    if (sum % 2 == 0)
                    {
                       
                        Console.WriteLine($"meet me there");
                    }
                    else
                    {
                        Console.WriteLine("busy");
                    }


                }

                input = Console.ReadLine();
            }

        }
        public static int SumOfDigits(string number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int num;
                if (int.TryParse(number[i].ToString(),out num ))
                {
                    sum += num;
                }
            }
            return sum;
        }

        public static int DiffOfDigits(string number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int num;
                if (int.TryParse(number[i].ToString(), out num))
                {
                    sum -= num;
                }
            }
            return sum;
        }
    }
}
