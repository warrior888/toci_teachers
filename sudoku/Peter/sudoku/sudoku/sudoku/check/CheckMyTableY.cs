﻿namespace sudoku.items
{
    public class CheckMyTableY
    {
        private int[] checkTab = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public bool checkTabY()
        {
            ////////////////////////
            /*
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    MyItems.tab[j - 1, i - 1] = i;
                }
            }
            */
            ////////////////////////
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    for (int i = 0; i < checkTab.Length; i++)
                    {
                        if (MyItems.tab[x,y] == checkTab[i])
                        {
                            checkTab[i] = 0;
                        }
                    }
                }
                for (int i = 0; i < checkTab.Length; i++)
                {
                    if (checkTab[i] != 0)
                    {
                        return false;
                    }
                    checkTab[i] = i + 1;
                }
            }
            return true;
        }
    }
}