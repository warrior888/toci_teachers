using System.Collections.Generic;
using Toci.Architects.Training.GhostRider.Generics;

namespace Toci.Architects.Training.piotex.Generics
{
    public class BankTreansferDictionary
    {
        public void Example()
        {
            Dictionary<int, string> Bank = new Dictionary<int, string>();

            Bank.Add(1060, "MBank");

            Dictionary<int, BankTransferBase> BankWithTransfer = new Dictionary<int, BankTransferBase>();

            BankWithTransfer.Add(1060, new MBank());
            BankWithTransfer.Add(1020, new PKO());
            BankWithTransfer.Add(1618, new myBank());


            foreach (var key in BankWithTransfer.Values)
            {
                key.Transfer("58 1060 4444 4444 4444 3333 3333",100000);
                
            }

        }
    }
}