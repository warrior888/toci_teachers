using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Architects.Training.Interfaces.GhostRider.Extending.PeselValidator;
using Toci.Architects.Training.Timo.Homework;
using Toci.Teachers.Architects.Tests.piotex;

namespace Toci.Teachers.Architects.Tests.Timo
{
    [TestClass]
    public class PeselValidatorTestTimo
    {
        [TestMethod]
        public void TestPeselValidatorTimo()
        {
            PeselValidatorTimo testPesel = new PeselValidatorTimo();
            Dictionary<string, IPeselValidator> testDictionary = new Dictionary<string, IPeselValidator>();

              bool result = testPesel.IsPeselValid("49040501580");

            testDictionary = testPesel.GetAllPeselValidators();
        }
    }
}