namespace sudoku.check
{
    public class chcekX
    {
        private int[] checkTab = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public bool checkTabX()
        {
            ///////////////////////
            /*
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Table.ClientTab[j-1,i-1] = j;
                }
            } 
            */
            ///////////////////////
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    for (int i = 0; i < checkTab.Length; i++)
                    {
                        if (Table.ClientTab[x, y] == checkTab[i])
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