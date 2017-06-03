namespace Toci.Architects.Training.anaxagore78.Generics
{
    public interface IBankTransfer
    {
        bool VerifyAccount(string account);

        bool VerifyAmount(double amount);

    }
}