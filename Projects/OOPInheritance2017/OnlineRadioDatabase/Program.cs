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
            List<Song> songs = new List<Song>();
            int numOfSongs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfSongs; i++)
            {

                    string[] inputTokens = Console.ReadLine().Split(';');

                    string artist = inputTokens[0];
                    string songName = inputTokens[1];
                    int[] time = inputTokens[2].Split(':').Select(int.Parse).ToArray();
                    int minutes = time[0];
                    int seconds = time[1];

                try
                {
                    Song song = new Song(artist,songName,minutes,seconds);

                    songs.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }
            Console.WriteLine($"Song added: {songs.Count}");

            int totalMinutes = songs.Sum(s => s.Minutes);
            int totalSeconds= songs.Sum(s => s.Seconds);

            totalSeconds += totalMinutes * 60;

            int finalSeconds = totalSeconds % 60;
            int finalMinutes = totalSeconds / 60;
            int finalHours = finalMinutes / 60;
            finalMinutes %= 60;

            Console.WriteLine($"Playlist length: {finalHours}h {finalMinutes}m {finalSeconds}s");


        }
    }
}
