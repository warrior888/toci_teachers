using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnamentApp
{
    public class WinerCheck : Form1
    {
        public int[] FirstRoundWinerChecking(int[] candidate, int[] ScoreChecking)
        {
            int temporary;
            if(ScoreChecking[0] < ScoreChecking[1])
            {
                temporary = candidate[0];
                candidate[0] = candidate[1];
                candidate[1] = temporary;
            }
            if (ScoreChecking[2] > ScoreChecking[3])
            {
                temporary = candidate[1];
                candidate[1] = candidate[2];
                candidate[2] = temporary;
            }
            if (ScoreChecking[2] < ScoreChecking[3])
            {
                temporary = candidate[1];
                candidate[1] = candidate[3];
                candidate[3] = temporary;
            }
            return candidate;
        }

        public int[] WinerChecking(int[] candidate, int[] ScoreChecking)
        {
            int temporary;
            if (ScoreChecking[0] < ScoreChecking[1])
            {
                temporary = candidate[0];
                candidate[0] = candidate[1];
                candidate[1] = temporary;
            }
            if (ScoreChecking[2] < ScoreChecking[3])
            {
                temporary = candidate[2];
                candidate[2] = candidate[3];
                candidate[3] = temporary;
            }
            return candidate;
        }
    }
}
