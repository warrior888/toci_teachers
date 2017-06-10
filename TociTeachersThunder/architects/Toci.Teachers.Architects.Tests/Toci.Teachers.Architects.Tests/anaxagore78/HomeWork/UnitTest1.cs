using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Architects.Training.anaxagore78.Homework.PeselValidator;
using Toci.Architects.Training.Interfaces.GhostRider.Extending.PeselValidator;

namespace Toci.Teachers.Architects.Tests.anaxagore78.HomeWork
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
            
            DisplayResult(resultOAllValidators, executionTimeSpan1);
        }

        [TestMethod]
        public void TestMethod3Parallel()
        {
            DateTime start = DateTime.Now;
            ValidatorOfPeselValidatorsAnaxagore78 validatorOfPeselParallel = new ValidatorOfPeselValidatorsAnaxagore78();
            Dictionary<string, ValidationResultAnaxagore78> resultOAllValidatorsParallel = validatorOfPeselParallel.ValidateAllValidatorsParallel();
            TimeSpan executionTimeSpan2 = DateTime.Now - start;

            DisplayResult(resultOAllValidatorsParallel, executionTimeSpan2);

        }

        [TestMethod]
        public void TestMethod3TaskFactory()
        {
            DateTime start = DateTime.Now;
            ValidatorOfPeselValidatorsAnaxagore78 validatorOfPeselTaskFactory = new ValidatorOfPeselValidatorsAnaxagore78();
            Dictionary<string, ValidationResultAnaxagore78> resultOAllValidatorsTaskFactory = validatorOfPeselTaskFactory.ValidateAllValidatorsTaskFactory();
            TimeSpan executionTimeSpan3 = DateTime.Now - start;

            DisplayResult(resultOAllValidatorsTaskFactory, executionTimeSpan3);
        }

        private static void DisplayResult(Dictionary<string, ValidationResultAnaxagore78> resultOAllValidators, TimeSpan executionTimeSpan)
        {
            foreach (var result in resultOAllValidators)
            {
                Console.WriteLine("Walidator uzytkownika: " + result.Key + ", odnalazł prawidłowych numerów PESEL: " +
                                  result.Value.Validated + ", nieprawidłowych: " + result.Value.NotValidated);
                Console.WriteLine(result.Value.Exceptions?.Count > 0 ? "Zgłoszone wyjątki:" : null);
                int i = 1;
                foreach (var exception in result.Value.Exceptions)
                {
                    Console.WriteLine(i++ + ") " + exception.Key + " : " + exception.Value + " razy");
                }
                Console.WriteLine("Całkowity czas walidacji:" + result.Value.ExecutionTime + " milisekund");
                Console.WriteLine("______________________________________________________");
            }
            Console.WriteLine();
            Console.WriteLine("Czas testu: " + executionTimeSpan);
        }
    }
}
