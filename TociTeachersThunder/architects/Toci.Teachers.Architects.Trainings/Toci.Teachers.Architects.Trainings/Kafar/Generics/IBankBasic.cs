using System.Dynamic;

namespace Toci.Architects.Training.Kafar.Generics
{
    public interface IBankBasic
    {
        bool VerifyAccount(string account);
        bool VerifyAmount(double account);
    }
}