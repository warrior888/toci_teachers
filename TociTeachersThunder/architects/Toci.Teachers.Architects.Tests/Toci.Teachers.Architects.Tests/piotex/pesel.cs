using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Architects.Training.piotex.peselHomework;

namespace Toci.Teachers.Architects.Tests.piotex
{
    [TestClass]
    public class pesel
    {
        [TestMethod]
        public void testMyMetod()
        {
            PeselValidatorpiotex validatorpiotex = new PeselValidatorpiotex();
            validatorpiotex.IsPeselValid("92072210625");

            bool actual = validatorpiotex.IsPeselValid("92072210625");
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        
    }
}