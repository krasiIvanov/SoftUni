using System;

namespace SleepyTom
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int holidayPlay = days * 127;
            int workdaysPlay = (365 - days) * 63;
            int totalPlay = holidayPlay + workdaysPlay;
            int left = Math.Abs(30000 - totalPlay);
            int hours = left / 60;
            int min = Math.Abs((hours * 60) - left);
            if (30000 > totalPlay)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, min);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, min);
            }
        }
    }
}