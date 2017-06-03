using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Architects.Training.GhostRider.Generics;

namespace Toci.Architects.Training.anaxagore78.Generics
{
    class InteligoTransfer:  BankTransferBase, IBankTransfer
    {
        public override bool Transfer(string account, double amount)
        {
            return (VerifyAmount(amount) && VerifyAccount(account));
        }

        public bool VerifyAccount(string account)
        {
            char[] chars = account.ToCharArray();
            return chars.Where(char.IsDigit).Count().Equals(26);
        }

        public bool VerifyAmount(double amount)
        {
            return amount > 0 ;
        }
    }
}
