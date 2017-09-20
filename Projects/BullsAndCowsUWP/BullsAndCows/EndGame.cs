using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCows
{
   public class EndGame
    {

        public int moves { get; set; }
        public string resultType { get; set; }
        public string targetNumber { get; set; }

        public EndGame(int moves,string resultType, string targetNumber)
        {
            this.moves = moves;
            this.resultType = resultType;
            this.targetNumber = targetNumber;
        }
    }
}
