using System.Windows.Forms;

namespace sudoku
{
    public class Table
    {
        public static int tabSizeX = 9;
        public static int tabSizeY = 9;
        public static int[,] ClientTab = new int[9,9];

        public Table(Form1 f1)
        {
            makeTable(f1);
        }

        public void makeTable(Form1 f1)
        {
            for (int i = 0,slizeY =0; i < tabSizeY; i++)
            {
                if (i % 3 == 0)
                {
                    ItemFactory.CreateItem(f1, 0, i * ButtonBase.sizeY + slizeY, WhatItem.MyLabelY);
                    slizeY += 3;
                }
                if (i == 8)
                {
                    ItemFactory.CreateItem(f1, 0, (i+1) * ButtonBase.sizeY + slizeY, WhatItem.MyLabelY);
                }
                for (int j = 0, slizeX =0; j < tabSizeX; j++)
                {
                    if (j % 3 == 0)
                    {
                        ItemFactory.CreateItem(f1, j * ButtonBase.sizeX + slizeX, 0, WhatItem.MyLabelX);
                        slizeX += 3;
                    }
                    if (j == 8)
                    {
                         ItemFactory.CreateItem(f1, (j+1) * ButtonBase.sizeX + slizeX, 0, WhatItem.MyLabelX);
                    }


                    if (ReadyTab.getNumber() == " ")
                    {
                        ItemFactory.CreateItem(f1, j * ButtonBase.sizeX + slizeX, i * ButtonBase.sizeY + slizeY, WhatItem.NormalButton);
                    }
                    else
                    {
                        ItemFactory.CreateItem(f1, j * ButtonBase.sizeX + slizeX, i * ButtonBase.sizeY + slizeY, WhatItem.ReadOnlyButton);
                    }
                    ReadyTab.licz++;
                    
                }
            }
            ItemFactory.CreateItem(f1,300,300, WhatItem.CheckButton);
        }
    }
}