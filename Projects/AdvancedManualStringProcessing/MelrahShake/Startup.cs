using System;
using System.Text;

namespace MelrahShake
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patern = Console.ReadLine();

            bool isRemove = true;
            while (isRemove)
            {
                int inputLenght = input.Length;
                int firstIndex = input.IndexOf(patern);
                int lastIndex = input.LastIndexOf(patern);

                if (firstIndex > -1 && lastIndex > -1 && patern.Length > 0)
                {
                    StringBuilder newinput = new StringBuilder(input);
                    newinput.Remove(firstIndex, patern.Length);
                    newinput.Remove(lastIndex - patern.Length, patern.Length);
                    input = newinput.ToString();
                    Console.WriteLine("Shaked it.");
                    newinput = new StringBuilder(patern);
                    if (patern.Length > 0)
                    {
                        newinput.Remove(patern.Length / 2, 1);
                        patern = newinput.ToString();
                    }
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    break;
                }
            }
        }
    }
}