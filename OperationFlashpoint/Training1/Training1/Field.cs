using Training1.Interfaces;

namespace Training1
{
    public class Field : IField
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public int Colour
        {
            get { return (XCoordinate + YCoordinate) % 2 == 1 ? 0 : 1; }
            
        }
        public IFigure CurrentFigure { get; set; }
    }
}