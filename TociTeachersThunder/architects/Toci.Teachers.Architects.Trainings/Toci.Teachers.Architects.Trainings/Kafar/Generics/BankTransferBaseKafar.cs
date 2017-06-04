using System;
using System.IO;
using System.Numerics;

namespace Toci.Architects.Training.Kafar.Generics
{
    public class BankTransferBaseKafar : IBankKafarsBasic
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        
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
            foreach (string line in File.ReadAllLines(@"..\..\..\Toci.Teachers.Architects.Trainings\Kafar\Generics\banks.txt"))
                if (line.Contains(bankId))
                {
                    Name = line.Substring(bankId.Length + 1);
                    check = true;
                    break;
                }
                else check = false;

            return check;
        }

        public bool VerifyAmount(double amount)
        {
            if (!(amount >= 0.0)) return false;
            Amount = amount;
            return true;
        }
    }
}