using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase
{
    class Song
    {
        private string title;
        private string artistName;
        private int minutes;
        private int seconds;

        public Song(string artistName, string title, int minutes, int seconds)
        {
            this.ArtistName = artistName;
            this.Title = title;           
            this.Minutes = minutes;
            this.Seconds = seconds;

        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                if (value.Length<3 || value.Length>20)
                {
                    throw new InvalidSongNameException();
                }
                title = value;
            }
        }

        public string ArtistName
        {
            get
            {
                return artistName;
            }

            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException();
                }

                artistName = value;
            }
        }

        public int Minutes
        {
            get
            {
                return minutes;
            }

            set
            {
                if (value<0 || value>14)
                {
                    throw new InvalidSongMinutesException();
                }

                minutes = value;
            }
        }

        public int Seconds
        {
            get
            {
                return seconds;
            }

            set
            {
                if (value<0||value>59)
                {
                    throw new InvalidSongSecondsException();
                }
                seconds = value;
            }
        }
    }
}
