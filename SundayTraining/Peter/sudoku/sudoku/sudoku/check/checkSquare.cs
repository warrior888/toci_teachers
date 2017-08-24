namespace sudoku.check
{
    public class checkSquare
    {
        private int[] checkTab = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public bool CheckMySquare()
        {
            ////////////////
            /*
             for (int i = 0; i < 9; i++)
             {
                 for (int j = 0; j < 9; j++)
                 {
                     Table.ClientTab[i, j] = 0;
                 }
             }
             
            int licz = 1;
             for (int i = 0; i < 3; i++)
             {
                 for (int j = 0; j < 3; j++)
                 {


                     ///////////weryfikuj pojedynczy kwadrat
                     for (int k = 0; k < 3; k++)
                     {
                         for (int l = 0; l < 3; l++)
                         {
                             Table.ClientTab[l + j*3, k + i*3] = licz;
                             licz++;
                             if (licz == 10)
                             {
                                 licz = 1;
                             }
                         }
                     }
                     ///////////////////



                 }
             }
            */
            ///////////
            for (int m = 0; m < 3; m++)
            {
                for (int n = 0; n < 3; n++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        for (int x = 0; x < 3; x++)
                        {
                            for (int j = 0; j < checkTab.Length; j++)
                            {
                                if (Table.ClientTab[x + n * 3, y + m * 3] == checkTab[j])
                                {
                                    checkTab[j] = 0;
                                }
                            }
                        }
                    }
                    for (int a = 0; a < checkTab.Length; a++)
                    {
                        if (checkTab[a] != 0)
                        {
                            return false;
                        }
                        checkTab[a] = a + 1;
                    }
                }
            }
            return true;
        }
    }
}