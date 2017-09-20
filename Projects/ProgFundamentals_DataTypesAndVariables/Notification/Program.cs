using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string cmd = Console.ReadLine();

                if (cmd!="success" && cmd!="error")
                {
                    continue;
                }
                string operation = Console.ReadLine();
                string message = Console.ReadLine();

                if (cmd=="success")
                {
                    ShowSucces(operation,message);
                }
                else
                {
                    int code = int.Parse(message);
                    ShowError(operation, code);
                }
            }

        }
        public static void ShowSucces(string operation,string message)
        {
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {message}");
        }
        public static void ShowError(string operation, int code)
        {
            string reason = "";
            if (code<0)
            {
                reason = "Internal System Failure";
            }
            else
            {
                reason = "Invalid Client Data";
            }
            Console.WriteLine($"Failed to execute {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error code: {code}");
            Console.WriteLine($"Reason: {reason}");
        }
    }
}
