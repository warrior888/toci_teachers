using System;
using System.IO;
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

            string bankId = account.Substring(2, 4);
            foreach (string line in File.ReadAllLines(@"C:\Users\mlote\Documents\SourceTree\toci_teachers\TociTeachersThunder\architects\Toci.Teachers.Architects.Trainings\Toci.Teachers.Architects.Trainings\Kafar\Generics\banks.txt"))
                if (line.Contains(bankId)) Name = line.Substring(bankId.Length + 1);

            if (VerifyAccount(account) && VerifyAmount(amount))
            {
                return true;
            }

            return false;
        }
    }
}