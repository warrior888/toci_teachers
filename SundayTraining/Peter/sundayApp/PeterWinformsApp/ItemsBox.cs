using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PeterWinformsApp
{
    public static class ItemsBox 
    {
        public static Dictionary<string, int> lexicon = new Dictionary<string, int>();
        public static Dictionary<string, int> lexiconSecondStage = new Dictionary<string, int>();
        public static Dictionary<string, int> lexiconOfWiners = new Dictionary<string, int>();
        public static TextBox StartPlayerName = new TextBox();
        public static TextBox PointsBox = new TextBox();
        public static TextBox PlayerNameBox = new TextBox();
        public static int makeGroupsSave = 0;
        public static int toTwo = 0;
        public static int toFour = 0;
    }
}