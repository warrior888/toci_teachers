using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Toci.Architects.Training.Interfaces.GhostRider.Extending.PeselValidator;


namespace Toci.Architects.Training.anaxagore78.Homework.PeselValidator
{
    public class ReflectionAggregatorAnaxagore78 : IReflectionAggregator
    {
        public Dictionary<string, IPeselValidator> GetAllPeselValidators()
        {
            Dictionary<string, IPeselValidator> peselValidators = new Dictionary<string, IPeselValidator>();

            Type[] allTypesInAssembly = Assembly.GetExecutingAssembly().GetTypes(); //.Where()

            Type seekedForType = typeof(IPeselValidator);


            IEnumerable<Type> derivingTypes = allTypesInAssembly.Where(m => seekedForType.IsAssignableFrom(m));

            foreach (var derivingType in derivingTypes)
            {
                IPeselValidator item = (IPeselValidator)Activator.CreateInstance(derivingType);
                peselValidators.Add(item.Name(), item);
            }
            return peselValidators;
        }



    }
}