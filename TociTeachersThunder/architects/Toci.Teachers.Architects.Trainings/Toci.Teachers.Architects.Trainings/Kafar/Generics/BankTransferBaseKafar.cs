using System;
using System.IO;

namespace Toci.Architects.Training.Kafar.Generics
{
    public class BankTransferBaseKafar : IBankBasic
    {
        public bool VerifyAccount(string account)
        {
            const string path = @"C:\Users\mlote\Documents\SourceTree\toci_teachers\TociTeachersThunder\architects\Toci.Teachers.Architects.Trainings\Toci.Teachers.Architects.Trainings\Kafar\Generics\banks.txt";
            FileStream banksFileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader banksStreamReader = new StreamReader(banksFileStream);
            bool check = banksStreamReader.ReadToEnd().Contains(account);
            banksFileStream.Close();

            return check;
        }

        public bool VerifyAmount(double amount)
        {
            return amount >= 0.0;
        }
    }
}