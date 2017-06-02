using System.Dynamic;

namespace Toci.Architects.Training.Kafar.Generics
{
    public interface IBankKafarsBasic
    {
        bool VerifyAccount(string account);
        bool VerifyAmount(double account);
    }
}