using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Architects.Training.GhostRider.Generics;

namespace Toci.Architects.Training.anaxagore78.Generics
{
    public class BankTransferDictionaryExample
    {
        public void Example()
        {
            Dictionary<string, BankTransferBase> transfersDict =
                new Dictionary<string, BankTransferBase>
                {
                    {"1020", new InteligoTransfer()},
                    {"1240", new PekaoTransfer()},
                    {"2120", new SantanderTransfer()}
                };

            foreach (var bank in transfersDict.Values)
            {
                bank.Transfer("58 1240 1112 1111 0010 0944 9739", 100);
            }
        }
    }
}
