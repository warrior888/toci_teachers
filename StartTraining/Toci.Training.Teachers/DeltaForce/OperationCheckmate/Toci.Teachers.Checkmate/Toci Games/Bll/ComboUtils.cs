using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Toci_Games.Bll
{
    public class ComboUtils
    {
        private RadioButton t = new RadioButton();
        

        public static Dictionary<string, RadioButton> AllGamesWeOffer = new Dictionary<string, RadioButton>
        {
            {"Chess",  new RadioButton() { Text = "Chess"}},
            {"Minesweeper",  new RadioButton() { Text = "Minesweeper"}},
            {"Mastermind",  new RadioButton() { Text = "Mastermind"}},
        };

        public void test()
        {
         //   t.Text
        }

        public int j = 0;

        public void DSA(string dupa)
        {
            j++;
            Func<string, bool> dsa = (str) => str == "bartek";
            Func<string, bool, int, Dictionary<string, List<int>>> a = 
                
                (str, boolVal, intv) => new Dictionary<string, List<int>>();
        }

        public void TpShowdown()
        {

            List<string> names = new List<string>();


            for (int i = 0; i < 100; i++)
            {
                names.Add("baGRPIOTRREK" + i);
            }

            names.AsParallel().WithDegreeOfParallelism(8).ForAll(DSA);
        }
    }
}

