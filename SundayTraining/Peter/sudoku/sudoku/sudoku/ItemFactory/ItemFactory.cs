using System;
using System.Collections.Generic;

namespace sudoku
{
    public static class ItemFactory
    {
        private static Form1 f1;
        private static int posX;
        private static int posY;

        private static Dictionary<WhatItem , Func<IBaseThing>> ItemDictionary = new Dictionary<WhatItem, Func<IBaseThing>>()
        {
            {WhatItem.NormalButton, () =>new NormalButton(f1,posX,posY)  },
            {WhatItem.MyLabelX, () =>  new MyLableX(f1,posX,posY)},
            {WhatItem.MyLabelY, () =>  new MyLabelY(f1,posX,posY)},
            {WhatItem.ReadOnlyButton, () =>  new ReadOnlyButton(f1,posX,posY)},
            {WhatItem.CheckButton, () =>  new CheckButton(f1,posX,posY)}
        };

        public static IBaseThing CreateItem(Form1 f1, int posX, int posY, WhatItem whatItem)
        {
            ItemFactory.posX = posX;
            ItemFactory.posY = posY;
            ItemFactory.f1 = f1;
            return ItemDictionary.ContainsKey(whatItem) ? ItemDictionary[whatItem]() : null;
        }
    }
}