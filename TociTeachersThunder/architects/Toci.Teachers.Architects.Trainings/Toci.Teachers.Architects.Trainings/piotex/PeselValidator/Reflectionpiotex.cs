using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Toci.Architects.Training.Interfaces.GhostRider.Extending.PeselValidator;

namespace Toci.Architects.Training.piotex.peselHomework
{
    public class Reflectionpiotex : IReflectionAggregator
    {
        public Dictionary<string, IPeselValidator> GetAllPeselValidators()
        {
            Dictionary<string,IPeselValidator> succeedingNewDictionary = new Dictionary<string, IPeselValidator>();

            Type typeOfI = typeof(IPeselValidator);
            Type[] allTypes = Assembly.GetExecutingAssembly().GetTypes();

            allTypes.Where(m => typeOfI.IsAssignableFrom(m));

            IEnumerable<Type> difrentTypes = allTypes.Where(m => typeOfI.IsAssignableFrom(m));

            foreach (var element in difrentTypes)
            {
                IPeselValidator item = (IPeselValidator) Activator.CreateInstance(element);
                succeedingNewDictionary.Add(item.Name(),item);
            }
            return succeedingNewDictionary;
        }
    }
}