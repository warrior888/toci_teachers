using Toci.Architects.Training.GhostRider.Generics;

namespace Toci.Architects.Training.piotex.Generics
{
    public class MBank : BankTransferBase
    {
        public override bool Transfer(string account, double amount)
        {
            return test(account) && amount > 0;
            

        }

        public bool test(string account)
        {
            return account[3].ToString() + account[4].ToString() + account[5].ToString() + account[6].ToString() == "1060";
        }
    }
}