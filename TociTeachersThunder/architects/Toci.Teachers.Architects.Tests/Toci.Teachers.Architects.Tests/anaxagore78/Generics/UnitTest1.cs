using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Architects.Training.anaxagore78.Homework.PeselValidator;
using Toci.Architects.Training.Interfaces.GhostRider.Extending.PeselValidator;
using System.Collections.Generic;

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
            validator.IsPeselValid(pesel);
            //Console.WriteLine("{0} - {1} numer pesel", pesel, ((validator.IsPeselValid(pesel)) ? "poprawny" : "niepoprawny"));
        }


        [TestMethod]
        public void TestMethod2()
        {
            IReflectionAggregator aggregator = new ReflectionAggregatorAnaxagore78();
            Dictionary<string, IPeselValidator> validators = aggregator.GetAllPeselValidators();

        }


        [TestMethod]
        public void TestMethod3()
        {
            DateTime start = DateTime.Now;
            ValidatorOfPeselValidatorsAnaxagore78 validatorOfPesel = new ValidatorOfPeselValidatorsAnaxagore78();
            Dictionary<string, ValidationResultAnaxagore78> resultOAllValidators = validatorOfPesel.ValidateAllValidators();
            TimeSpan executionTimeSpan1 = DateTime.Now - start;

            start = DateTime.Now;
            ValidatorOfPeselValidatorsAnaxagore78 validatorOfPeselV2 = new ValidatorOfPeselValidatorsAnaxagore78();
            Dictionary<string, ValidationResultAnaxagore78> resultOAllValidatorsParallel = validatorOfPeselV2.ValidateAllValidatorsParallel();
            TimeSpan executionTimeSpan2 = DateTime.Now - start;
        }
    }
}
