using System.Collections.Generic;
using System.Linq.Expressions;

namespace Toci.Architects.Training.Kafar.Generics
{
    public class BankTransferKafarsDictionary
    {
        public void Example()
        {
            Dictionary<string, BankTransferKafar> transferDictionary = new Dictionary<string, BankTransferKafar>();

            transferDictionary.Add("1160", new BankTransferKafar());
        }
    }
}