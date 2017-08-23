namespace sudoku.items
{
    public class MyTable
    {
        MyButton button = new MyButton();
        MyLabel Label = new MyLabel();

        public void makePlayground(Form1 form1)
        {
            for (int y = 0, slideY =0; y < 9; y++)
            {
                if (y%3 == 0 )
                {
                    Label.MakeLabelY(form1, 0, y * MyItems.sizeY + slideY);
                    slideY += 3;
                }
                if (y== 8)
                {
                    Label.MakeLabelY(form1, 0, Label.sizeXLabelY);
                }
                for (int x = 0, slideX = 0; x < 9; x++)
                {
                    if (x%3==0 )
                    {
                        Label.MakeLabelX(form1, x * MyItems.sizeX + slideX, 0);
                        slideX += 3;
                    }
                    if (x==8 )
                    {
                        Label.MakeLabelX(form1, Label.sizeYLabelX  , 0);
                    }
                    new MyButton(form1, x * MyItems.sizeX + slideX, y * MyItems.sizeY + slideY);
                }
            }
            button.MakeSpecialButton(form1,Label.sizeXLabelY, Label.sizeYLabelX);

        }
    }
}