using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            List<Song> playlist = new List<Song>();

            for (int i = 0; i < num; i++)
            {
                string[] songInfo = Console.ReadLine().Split(';');

                string artistName = songInfo[0];
                string songName = songInfo[1];

                int[] songTime = songInfo[2].Split(':').Select(int.Parse).ToArray();

                int minutes = songTime[0];
                int seconds = songTime[1];

                try
                {
                    Song song = new Song(artistName, songName, minutes, seconds);
                    playlist.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            
            }

            Console.WriteLine($"Songs added: {playlist.Count}");

            int totalMinutes = playlist.Sum(s => s.Minutes);
            int totlaSeconds = playlist.Sum(s => s.Seconds);

            totlaSeconds += totalMinutes * 60;

            int finalMinutes = totlaSeconds / 60;
            int finalSeconds = totlaSeconds % 60;
            int finalHours = finalMinutes / 60;
            finalMinutes %= 60;

            Console.WriteLine($"Playlist length: {finalHours}h {finalMinutes}m {finalSeconds}s");


        }
    }
}
