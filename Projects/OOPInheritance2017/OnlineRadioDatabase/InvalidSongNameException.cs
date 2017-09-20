using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase
{
    class InvalidSongNameException : InvalidSongException
    {
        private const string MESSAGE = "Song name should be between 3 and 30 symbols.";

        public InvalidSongNameException() :base(MESSAGE)
        {
        }

        public InvalidSongNameException(string message) : base(message)
        {
        }
    }
}
