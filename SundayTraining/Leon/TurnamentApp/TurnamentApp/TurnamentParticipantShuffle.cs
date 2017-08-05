using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TurnamentApp
{
    public class TurnamentParticipantShuffle : ShuffleBase<string[]>
    {
        public override string[] Shuffle(string[] random)
        {
            string[] candidate = new string[random.Length];
            return candidate;
        }
    }
}