using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Architects.Training.anaxagore78.Homework.PeselValidator;
using Toci.Architects.Training.Interfaces.GhostRider.Extending.PeselValidator;

namespace Toci.Teachers.Architects.Tests.anaxagore78.Generics
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //string pesel = "78061906750"; //bledny
            string pesel = "78061906751"; //poprawny
            //string pesel = "80090102444"; //poprawny
            IPeselValidator validator = new PeselValidatorAnaxagore78();
            Console.WriteLine($"{pesel}- {((validator.IsPeselValid(pesel)) ? "poprawny" : "niepoprawny")} numer pesel");

            PeselValidatorAnaxagore78 validatorV2 = new PeselValidatorAnaxagore78();

            Console.WriteLine(validatorV2.GetSex(pesel));
            IReflectionAggregator aggregator = new ReflectionAggregatorAnaxagore78();
            aggregator.GetAllPeselValidators();
        }
    }
}
