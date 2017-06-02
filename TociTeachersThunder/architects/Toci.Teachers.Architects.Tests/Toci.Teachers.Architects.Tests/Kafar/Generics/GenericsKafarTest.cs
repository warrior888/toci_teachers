using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Architects.Training.GhostRider.Generics;
using Toci.Architects.Training.Kafar.Generics;

namespace Toci.Teachers.Architects.Tests.Kafar.Generics
{
    [TestClass]
    public class GenericsKafarTest
    {
        [TestMethod]
        public void BankTransferKafarsDictionaryTest()
        {
            BankTransferKafarsDictionary dictionaryTest = new BankTransferKafarsDictionary();

            dictionaryTest.Example();
        }

    }
}