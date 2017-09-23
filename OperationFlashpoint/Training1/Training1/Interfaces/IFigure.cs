namespace Training1.Interfaces
{
    public interface IFigure
    {
        bool Move(IField source, IField destination, bool testCanMove = true);
        bool Move(IField source, IField destination);
    }
}