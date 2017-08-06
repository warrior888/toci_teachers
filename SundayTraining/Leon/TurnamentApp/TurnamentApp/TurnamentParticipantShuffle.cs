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
            Random tableNumber = new Random();

            for (int i = 0, j = 0; i < random.Length; i++)
            {
                j = tableNumber.Next(0, random.Length-2);
                while(candidate[j] != null)
                {
                    if(j == 19)
                    {
                        j = 0;
                    }
                    j++;
                }
                candidate[j] = random[i];
            }
            return candidate;
        }

        public override string[][] ToSplitGroups(string[] candidate)
        {
            string[][] result = new string[4][];
            for(int i = 0, k = 0; i < result.Length; i++)
            {
                result[i] = new string[5];
                for(int j = 0; j < result[i].Length; j++)
                {
                    result[i][j] = candidate[k];
                    k++;
                }
            }
            return result;
        }
    }
}