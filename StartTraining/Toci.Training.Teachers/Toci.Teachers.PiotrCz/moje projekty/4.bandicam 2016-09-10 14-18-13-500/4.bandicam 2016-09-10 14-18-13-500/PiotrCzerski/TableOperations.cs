namespace _4.bandicam_2016_09_10_14_18_13_500.PiotrCzerski
{
    public class TableOperations
    {
        public int[] GetElementFromTable(int[] table, int graterThan)
            
            //ma przyjac tablice   table = 1,2,3,4,5,6,7,8,9 i nastepnie ma 
            // ta tablice sprawdzic wzgledem greaterThan i greatherThan = 5
            //czyli wynikowo ma byc 6,7,8,9

        {
            int[] result = new int[table.Length]; // for na tablicy table && result osiagnie taki sam rozzmiar co tablica
                                                  // wejsciowa

            for (int i = 0, j=0; i < table.Length; i++)
            {
                if (table[i] > graterThan)
                {
                
                    // dodajemy do wynikowej tablicy
                    result[j] = table[i];
                    j++;
                }

            }
            return result;
        }
    }
}