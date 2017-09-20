using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase
{
    class InvalidSongSecondsException : InvalidSongLengthException
    {
        private const string MESSAGE = "Song seconds should be between 0 and 59.";

        public InvalidSongSecondsException(): base(MESSAGE)
        {
        }

        public InvalidSongSecondsException(string message) : base(message)
        {
        }
    }
}
