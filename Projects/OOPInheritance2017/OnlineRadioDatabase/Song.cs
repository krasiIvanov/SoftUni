using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase
{
    class Song
    {
        private string artist;
        private string songName;
        private int minutes;
        private int seconds;

        public Song(string artist, string songName, int minutes, int seconds)
        {

            this.Artist = artist;
            this.SongName = songName;
            this.Minutes = minutes;
            this.Seconds = seconds;

        }

        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value<0 || value>59)
                {
                    throw new InvalidSongSecondsException();
                }
                seconds = value;
            }
        }


        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value<0 || value>14)
                {
                    throw new InvalidSongMinutesException();
                }
                minutes = value;
            }
        }


        public string SongName
        {
            get { return songName; }
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidSongNameException();
                }

                songName = value;
            }
        }


        public string Artist
        {
            get { return artist; }
            set
            {
                if (value.Length<3 || value.Length>20)
                {
                    throw new InvalidArtistNameException();
                }

                artist = value;
            }
        }


    }
}
