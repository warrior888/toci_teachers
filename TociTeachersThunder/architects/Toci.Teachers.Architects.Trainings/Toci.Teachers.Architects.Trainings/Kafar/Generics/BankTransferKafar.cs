using System;
using System.IO;
using Toci.Architects.Training.GhostRider.Generics;

namespace Toci.Architects.Training.Kafar.Generics
{
    public class BankTransferKafar : BankTransferBase
    {
        BankTransferBaseKafar exampleOfTransfer = new BankTransferBaseKafar();
        public override bool Transfer(string account, double amount)
        {
            return (exampleOfTransfer.VerifyAccount(account) && exampleOfTransfer.VerifyAmount(amount));
        }
    }
}