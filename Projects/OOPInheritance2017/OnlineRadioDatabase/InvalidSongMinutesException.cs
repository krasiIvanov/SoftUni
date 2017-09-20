using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase
{
    class InvalidSongMinutesException : InvalidSongLengthException
    {
        private const string MESSAGE = "Song minutes should be between 0 and 14.";

        public InvalidSongMinutesException():base(MESSAGE)
        {
        }

        public InvalidSongMinutesException(string message) : base(message)
        {
        }
    }
}
