using System.Drawing;
using System.Windows.Forms;

namespace masterMINDv2.fieldFactory
{
    public abstract class AbstractField
    {
        public int size = 50;
        public int posX;
        public static int posY ;

        public abstract Button makeField(Form f1);
    }
}