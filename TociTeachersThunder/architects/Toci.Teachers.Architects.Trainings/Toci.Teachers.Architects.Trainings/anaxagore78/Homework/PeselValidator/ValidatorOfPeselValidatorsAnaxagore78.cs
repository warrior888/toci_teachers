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
        

        public Dictionary<string, ValidationResultAnaxagore78> ValidateAllValidators(List<string> peseList)
        {
            var validators = GetDictPeselValidators();
            //List<string> peseList = GetStringsFromFile(_fileName);
            Dictionary<string, ValidationResultAnaxagore78> validationResults = new Dictionary<string, ValidationResultAnaxagore78>();

            foreach (var validator in validators)
            {
                ValidationTask(peseList, validator, validationResults);
            }
            return validationResults;
        }

        public Dictionary<string, ValidationResultAnaxagore78> ValidateAllValidatorsTaskFactory(List<string> peseList)
        {
            var validators = GetDictPeselValidators();
            //List<string> peseList = GetStringsFromFile(_fileName);
            Dictionary<string, ValidationResultAnaxagore78> validationResults = new Dictionary<string, ValidationResultAnaxagore78>();

            Task.WaitAll(validators.Select(validator => Task.Factory.StartNew(() => ValidationTask(peseList, validator, validationResults))).ToArray());

            return validationResults;
        }



        public Dictionary<string, ValidationResultAnaxagore78> ValidateAllValidatorsParallel(List<string> peseList)
        {
            var validators = GetDictPeselValidators();
            //List<string> peseList = GetStringsFromFile(_fileName);
            Dictionary<string, ValidationResultAnaxagore78> validationResults = new Dictionary<string, ValidationResultAnaxagore78>();

            Parallel.ForEach(validators, (validator) => { ValidationTask(peseList, validator, validationResults); });
            return validationResults;
        }

        private static Dictionary<string, IPeselValidator> GetDictPeselValidators()
        {
            IReflectionAggregator aggregator = new ReflectionAggregatorAnaxagore78();
            Dictionary<string, IPeselValidator> validators = aggregator.GetAllPeselValidators();
            return validators;
        }

        private static void ValidationTask(List<string> peseList, KeyValuePair<string, IPeselValidator> validator, Dictionary<string, ValidationResultAnaxagore78> validationResults)
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


    }
}
