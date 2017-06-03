using System.Collections.Generic;
using System.Linq.Expressions;

namespace Toci.Architects.Training.Kafar.Generics
{
    public class BankTransferKafarsDictionary
    {
        public void Example()
        {
            BankTransferKafar newTransferKafar = new BankTransferKafar();
            newTransferKafar.Transfer("20 1160 2202 0000 0002 0963 4710", 100);

            Dictionary<string, BankTransferKafar> transferDictionary = new Dictionary<string, BankTransferKafar>();

            transferDictionary.Add("1160", newTransferKafar);
        }
    }
}