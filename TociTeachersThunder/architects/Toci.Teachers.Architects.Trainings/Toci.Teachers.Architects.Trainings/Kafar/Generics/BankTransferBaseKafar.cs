using System;
using System.IO;
using System.Numerics;

namespace Toci.Architects.Training.Kafar.Generics
{
    public class BankTransferBaseKafar : IBankKafarsBasic
    {
        public bool VerifyAccount(string account)
        {
            bool check = false;
            if (account.Length > 26)
            {
                account = account.Replace(" ", "");
            }
            
            if (account.StartsWith("PL"))
            {
                account = account.Remove(0, 2);
                account += "2521" + account.Substring(0, 2);
                account = account.Remove(0, 2);
            }
            else
            {
                account += "2521" + account.Substring(0, 2);
                account = account.Remove(0, 2);               
            }

            BigInteger accountNumber = BigInteger.Parse(account);
            if (accountNumber%97 == 1)
            {
                check = true;
            }

            string bankId = account.Substring(0, 4);
            foreach (string line in File.ReadAllLines(@"C:\Users\mlote\Documents\SourceTree\toci_teachers\TociTeachersThunder\architects\Toci.Teachers.Architects.Trainings\Toci.Teachers.Architects.Trainings\Kafar\Generics\banks.txt"))
                if (!line.Contains(bankId))
                {
                    check = false;
                }

            return check;
        }

        public bool VerifyAmount(double amount)
        {
            return amount >= 0.0;
        }
    }
}