using System;
using System.Collections.Generic;
using System.Linq;

namespace PeterWinformsApp
{
    public class ShuffleMethod 
    {
        public Dictionary<string, int> shuffle(Dictionary<string, int> objectList, int shuffleMaxNumber, int howManyToShuffel)
        {
            Dictionary<string, int> newDictionary = new Dictionary<string, int>();
            if (objectList.Count > 0)
            {
                string getString = "";
                Random rand = new Random();
                int getNumber = rand.Next(1, shuffleMaxNumber - 1);
                int getSmalNumber = rand.Next(1, objectList.Count);
                string[] tab = objectList.Keys.ToArray();

                for (int i = 0; i < tab.Length; i++)
                {
                    if (howManyToShuffel < objectList.Count && shuffleMaxNumber < objectList.Count)
                    {
                        getString = tab[i];
                        tab[i] = tab[getNumber];
                        tab[getNumber] = getString;
                        if (getNumber >= howManyToShuffel)
                        {
                            getNumber -= howManyToShuffel;
                        }
                    }
                    else
                    {
                        getString = tab[i];
                        tab[i] = tab[getSmalNumber - 1];
                        tab[getSmalNumber - 1] = getString;
                        if (getSmalNumber - 1 >= howManyToShuffel)
                        {
                            getSmalNumber -= howManyToShuffel - 1;
                        }
                    }
                }
                for (int i = 0; i < objectList.Count; i++)
                {
                    newDictionary.Add(tab[i], objectList[tab[i]]);

                }
            }
            return newDictionary;

        }

        
    }
}