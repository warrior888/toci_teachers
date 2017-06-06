using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Toci.Architects.Training.Interfaces.GhostRider.Extending.PeselValidator;
using Toci.Architects.Training.Properties;

namespace Toci.Architects.Training.anaxagore78.Homework.PeselValidator
{
    public class ValidatorOfPeselValidatorsAnaxagore78
    {

        public Dictionary<string, ValidationResultAnaxagore78> ValidateAllValidators()
        {
            IReflectionAggregator aggregator = new ReflectionAggregatorAnaxagore78();
            Dictionary<string, IPeselValidator> validators = aggregator.GetAllPeselValidators();
            string fileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Resources\pesel.csv";
            List<string> peseList = GetStringsFromFile(fileName);
            Dictionary<string, ValidationResultAnaxagore78> validationResults = new Dictionary<string, ValidationResultAnaxagore78>();

            foreach (var validator in validators)
            {
                ValidationResultAnaxagore78 validationResultAnaxagore78 = new ValidationResultAnaxagore78();
                DateTime start = DateTime.Now;
                foreach (var pesel in peseList)
                {
                    try
                    {
                        if (validator.Value.IsPeselValid(pesel))
                        {
                            validationResultAnaxagore78.Validated++;
                        }
                        else
                        {
                            validationResultAnaxagore78.NotValidated++;
                        }
                        //var i = (validator.Value.IsPeselValid(pesel))
                        //    ? validationResultAnaxagore78.Validated++
                        //    : validationResultAnaxagore78.NotValidated++;
                    }
                    catch (Exception exc)
                    {
                        AddException2Dict(validationResultAnaxagore78, exc);
                        //Console.WriteLine("Błąd przy sprawdzaniu: " + pesel + " => " + exc.Message);
                    }
                }
                TimeSpan executionTimeSpan = DateTime.Now - start;
                validationResultAnaxagore78.ExecutionTime = executionTimeSpan.TotalMilliseconds;
                validationResults.Add(validator.Key, validationResultAnaxagore78);
            }
            return validationResults;
        }

        public Dictionary<string, ValidationResultAnaxagore78> ValidateAllValidatorsParallel()
        {
            IReflectionAggregator aggregator = new ReflectionAggregatorAnaxagore78();
            Dictionary<string, IPeselValidator> validators = aggregator.GetAllPeselValidators();
            string fileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Resources\pesel.csv";
            List<string> peseList = GetStringsFromFile(fileName);
            Dictionary<string, ValidationResultAnaxagore78> validationResults = new Dictionary<string, ValidationResultAnaxagore78>();

            Parallel.ForEach(validators, (validator) =>
            {
                ValidationResultAnaxagore78 validationResultAnaxagore78 = new ValidationResultAnaxagore78();
                DateTime start = DateTime.Now;
                foreach (var pesel in peseList)
                {
                    try
                    {
                        if (validator.Value.IsPeselValid(pesel))
                        {
                            validationResultAnaxagore78.Validated++;
                        }
                        else
                        {
                            validationResultAnaxagore78.NotValidated++;
                        }
                    }
                    catch (Exception exc)
                    {
                        AddException2Dict(validationResultAnaxagore78, exc);
                    }
                }
                TimeSpan executionTimeSpan = DateTime.Now - start;
                validationResultAnaxagore78.ExecutionTime = executionTimeSpan.TotalMilliseconds;
                validationResults.Add(validator.Key, validationResultAnaxagore78);
            });
            return validationResults;
        }

        private static void AddException2Dict(ValidationResultAnaxagore78 result, Exception exc)
        {
            if (result.Exceptions.ContainsKey(exc.Message))
            {
                result.Exceptions[exc.Message]++;
            }
            else
            {
                result.Exceptions.Add(exc.Message, 1);
            }
        }

        private static List<string> GetStringsFromFile(string fileName)
        {
            List<string> lista = File.ReadAllLines(fileName).ToList();
            #region loop
            //using (StreamReader sr = new StreamReader(fileName))
            //{
            //    for (int i = 0; i < .Length; i++)
            //    {
            //        string pesel = sr.ReadLine();
            //        lista.Add(pesel);
            //    }
            //} 
            #endregion
            return lista;
        }
    }
}
