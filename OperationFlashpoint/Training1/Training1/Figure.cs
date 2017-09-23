using Training1.Interfaces;

namespace Training1
{
    public abstract class Figure : IFigure
    {
        /////////////

        public bool Move(IField source, IField destination, bool testCanMove = true)
        {
            throw new System.NotImplementedException();
        }

        public bool Move(IField source, IField destination)
        {
            throw new System.NotImplementedException();
        }
    }
}