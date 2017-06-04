namespace Toci.Architects.Training.Interfaces.GhostRider.Extending.PeselValidator
{
    public interface IPeselValidator
    {
        string Name(); // Ghostrider, Anaxore

        bool IsPeselValid(string pesel);
    }
}