using System.Drawing;
using Training1.Interfaces;

namespace Training1
{
    public class Field : IField
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
	    public Color color { get; set; }

	    public IFigure CurrentFigure { get; set; }
    }
}