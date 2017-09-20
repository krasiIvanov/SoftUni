using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTime
{
    class Program
    {
        static void Main(string[] args)
        {


            int exmHour = int.Parse(Console.ReadLine());
            int exmMin = int.Parse(Console.ReadLine());
            int arrHour = int.Parse(Console.ReadLine());
            int arrMin = int.Parse(Console.ReadLine());

            int exmMinutes = (exmHour * 60) +exmMin;
            int arrMinutes = (arrHour * 60) + arrMin;
            int minutes = Math.Abs(exmMinutes - arrMinutes);

           

            if ((exmMinutes==arrMinutes)||(minutes<=30 && exmHour>=arrHour && exmMinutes>=arrMinutes ))
            {
                if (exmMinutes == arrMinutes)
                {
                    Console.WriteLine("On Time");
                }
                else
                {
                    Console.WriteLine("On Time");
                    Console.WriteLine("{0} minutes before the start", minutes);
                }
                
            }
            else if (exmMinutes<arrMinutes)//9/00 8/30

            {
                Console.WriteLine("Late");
                if (minutes == 60)
                {
                    int hour = minutes / 60;
                    int min = minutes % 60;
                    Console.WriteLine("{0}:{1}0 hours after the start", hour, min);
                }
                else if (minutes >= 60)
                {
                    int hour = minutes / 60;
                    int min = minutes % 60;
                    Console.WriteLine("{0}:{1} hours after the start", hour, min);
                }
                else
                {
                    Console.WriteLine("{0} minutes after the start", minutes);
                }
            }
            else if ((exmMinutes > arrMinutes ))
            {
                Console.WriteLine("Early");
                if (minutes==60)
                {
                    int hour = minutes / 60;
                    int min = minutes % 60;
                    Console.WriteLine("{0}:{1}0 hours before the start", hour, min);
                }else if (minutes>=60)
                {
                    int hour = minutes / 60;
                    int min = minutes % 60;
                    Console.WriteLine("{0}:{1} hours before the start", hour,min);
                }
                else
                {
                    Console.WriteLine("{0} minutes before the start", minutes);
                }
                
            }



        }
    }
}
