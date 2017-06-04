using Toci.Architects.Training.GhostRider.Generics;

namespace Toci.Architects.Training.piotex.Generics
{
    public class myBank : BankTransferBase
    {
        public override bool Transfer(string account, double amount)
        {
            return account == "1618" && amount > 1000000;
        }
    }
}