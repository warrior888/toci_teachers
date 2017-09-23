namespace Training1.Interfaces
{
    public interface IField
    {
        int XCoordinate { get; set; }

        int YCoordinate { get; set; }

        int Colour { get;  }

        IFigure CurrentFigure { get; set; }
    }
}