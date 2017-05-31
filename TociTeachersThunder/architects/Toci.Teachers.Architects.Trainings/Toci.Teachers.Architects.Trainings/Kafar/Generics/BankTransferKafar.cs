using System;
using Toci.Architects.Training.GhostRider.Generics;

namespace Toci.Architects.Training.Kafar.Generics
{
    public class BankTransferKafar : BankTransferBaseKafar
    {
        public string Name { get; set; }
        public double Amount { get; set; }

        public bool Transfer(string account, double amount)
        {
            Amount = amount;
            return (VerifyAccount(account) && VerifyAmount(amount));
        }
    }
}