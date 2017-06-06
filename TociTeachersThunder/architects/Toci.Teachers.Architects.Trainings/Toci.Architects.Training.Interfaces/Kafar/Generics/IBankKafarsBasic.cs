namespace Toci.Architects.Training.Interfaces.Kafar.Generics
{
    public interface IBankKafarsBasic
    {
        string Name { get; set; }
        bool VerifyAccount(string account);
        bool VerifyAmount(double account);
    }
}