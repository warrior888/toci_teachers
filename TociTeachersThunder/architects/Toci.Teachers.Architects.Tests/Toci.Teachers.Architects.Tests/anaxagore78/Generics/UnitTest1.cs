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
            //string pesel = "78061906750"; //bledny
            string pesel = "78061906751"; //poprawny
            //string pesel = "80090102444"; //poprawny

            IPeselValidator peselValidator = new PeselValidatorAnaxagore78();
            Console.WriteLine("{0} -{1} numer pesel", pesel,
                ((peselValidator.IsPeselValid(pesel)) ? "poprawny" : "niepoprawny"));

            IReflectionAggregator aggregator = new ReflectionAggregatorAnaxagore78();

            Dictionary<string, IPeselValidator> validators = aggregator.GetAllPeselValidators();

            Dictionary<string, List<string>> validatorsStatus = new Dictionary<string, List<string>>();

            foreach (var validator in validators)
            {
                //try
                //{
                //    validator.Value.IsPeselValid(pesel);
                //}
                //catch (NotImplementedException notImplemented)
                //{
                //    validatorsStatus.Add(validator.Key,);
                //}
                //catch (Exception exc)
                //{

                //}

            }
        }
    }
}
