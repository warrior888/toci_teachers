using System.Collections.Generic;

namespace Toci.Architects.Training.GhostRider.Generics
{
    public class ComplexDictionaryExample
    {
        public void Example()
        {
            Dictionary<string, List<BankTransferBase>> whatever = new Dictionary<string, List<BankTransferBase>>();
                     //1060
            //Dictionary<string, BankTransferBase>

            whatever.Add("1140", new List<BankTransferBase> { new MbankTransfer() });
        }
    }
}