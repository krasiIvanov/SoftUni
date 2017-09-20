using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase
{
    class InvalidArtistNameException : InvalidSongException
    {
        private const string MESSAGE = "Artist name should be between 3 and 20 symbols.";

        public InvalidArtistNameException() : base(MESSAGE)
        {

        }

        public InvalidArtistNameException(string message) : base(message)
        {
        }
    }
}
