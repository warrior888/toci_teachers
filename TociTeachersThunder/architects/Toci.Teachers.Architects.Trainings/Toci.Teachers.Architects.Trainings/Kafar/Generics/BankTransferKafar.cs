using System;
using System.IO;
using Toci.Architects.Training.GhostRider.Generics;

namespace Toci.Architects.Training.Kafar.Generics
{
    public class BankTransferKafar : BankTransferBaseKafar
    {
        public bool Transfer(string account, double amount)
        {
            return (VerifyAccount(account) && VerifyAmount(amount));
        }
    }
}