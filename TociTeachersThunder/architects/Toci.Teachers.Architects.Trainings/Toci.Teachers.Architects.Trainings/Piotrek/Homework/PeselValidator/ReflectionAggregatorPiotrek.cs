using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Toci.Architects.Training.Interfaces.GhostRider.Extending.PeselValidator;
using Toci.Architects.Training.Interfaces.GhostRider.Inheritance;

namespace Toci.Architects.Training.Piotrek.Homework.PeselValidator
{
    public class ReflectionAggregatorPiotrek : IReflectionAggregator
    {
        public Dictionary<string, IPeselValidator> GetAllPeselValidators()
        {
            //Dictionary<string, IPeselValidator> dictionary = new Dictionary<string, IPeselValidator>();

            IPeselValidator pesel = new PeselValidatorPiotrek();
            Type[] allTypesInAssembly = Assembly.GetExecutingAssembly().GetTypes();

            Type seekedForType = typeof(IPeselValidator);

            Type piotrek = typeof(Piotrek.Homework.PeselValidator.PeselValidatorPiotrek);

            IEnumerable<Type> derivingTypes = allTypesInAssembly.Where(m => seekedForType.IsAssignableFrom(m));

            //foreach (var derivingType in derivingTypes)
            //{
            //    IPeselValidator item = (IPeselValidator)Activator.CreateInstance(derivingType);
            //    dictionary.Add(item.Name(), new PeselValidatorPiotrek());

            //}
            //return dictionary;

            return derivingTypes.Select(derivingType => (IPeselValidator) Activator.CreateInstance(derivingType)).ToDictionary(item => item.Name());

        }
    }
}