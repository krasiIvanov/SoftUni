using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase
{
    class InvalidSongLengthException : InvalidSongException
    {
        private const string MESSAGE = "Invalid song length.";

        public InvalidSongLengthException(): base(MESSAGE)
        {
        }

        public InvalidSongLengthException(string message) : base(message)
        {
        }
    }
}
