using System.Drawing;

namespace Training1.Interfaces
{
    public interface IField
    {
        int XCoordinate { get; set; }

        int YCoordinate { get; set; }
		
		Color color { get; set; }

        IFigure CurrentFigure { get; set; }
    }
}