using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using masterMINDv2.fieldFactory.classes;

namespace masterMINDv2
{
    public static class Helpers
    {
        public static Color[] TabOfColors = new []{ Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, };
        public static List<Button> fieldsList = new List<Button>();
        public static List<Button> destynyList = new List<Button>(){null,null,null,null};
        public static Color[] WhatColors = { Color.Red, Color.Azure, Color.Blue, Color.Black, Color.Gold, Color.Aquamarine };
        public static Form1 form1;
        public static Form2 form2;
        private static int numberOfColor;

        public static Color[] shuffle()
        {
            Color[] tab = { Color.Red, Color.Azure, Color.Blue, Color.Black, Color.Gold, Color.Aquamarine, Color.Red, Color.Azure, Color.Blue, Color.Black, Color.Gold, Color.Aquamarine, Color.Red, Color.Azure, Color.Blue, Color.Black, Color.Gold, Color.Aquamarine, Color.Red, Color.Azure, Color.Blue, Color.Black, Color.Gold, Color.Aquamarine, };
            int rand = new Random(DateTime.Now.Millisecond).Next(0, 11);
            for (int i = 0; i < rand; i++)
            {
                var keep = tab[i];
                tab[i] = tab[rand - i];
                tab[rand - i] = keep;
            }
            //tab[0] = Color.Red;
            //tab[1] = Color.Red;
            //tab[2] = Color.Red;
            //tab[3] = Color.Gold;

            return new[] { tab[0], tab[1], tab[2], tab[3] };
        }

        public static int validationFields()
        {
            int licz = 0;
            foreach (var fl in Helpers.fieldsList)
            {
                if (fl.BackColor != Helpers.TabOfColors[licz])
                {

                    return (2);
                }
                licz++;
            }
            if (Helpers.fieldsList.Count != 4)
            {
                return (3);
            }
            return (1);
        }

        public static void changeColor(this Button button)
        {
            if (!fieldsList.Contains(button))
            {
                fieldsList.Add(button);
                numberOfColor = 0;
            }

            foreach (var it in fieldsList)
            {
                if (it.BackColor == button.BackColor)
                {
                    for (int i = 0; i < WhatColors.Length; i++)
                    {
                        if (it.BackColor == WhatColors[i])
                        {
                            numberOfColor = i;
                            if (numberOfColor == WhatColors.Length - 1)
                            {
                                numberOfColor = 0;
                            }
                            else
                            {
                                numberOfColor++;
                            }
                        }
                    }
                }
            }
            button.BackColor = WhatColors[numberOfColor++];
            int liczba = button.Location.X / 60;

            destynyList[liczba] = button;
        }

        public static void getPrompt()
        {
            int licznik = 0;
            int posUser = 0;
            foreach (var fl in destynyList)
            {
                foreach (var wc in TabOfColors)
                {
                    if (fl != null && fl.BackColor == wc)
                    {
                        PromoptButtons.color[licznik] = Color.White;
                        if (destynyList[posUser].BackColor == TabOfColors[posUser])
                        {
                            PromoptButtons.color[licznik] = Color.Red;
                        }
                    }
                }
                licznik++;
                posUser++;
            }
        }
    }
}