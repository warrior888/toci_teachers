using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TurnamentApp
{
    public abstract class ShuffleBase<RandomShuffle>
    {
        public abstract RandomShuffle Shuffle(RandomShuffle random);
    }
}