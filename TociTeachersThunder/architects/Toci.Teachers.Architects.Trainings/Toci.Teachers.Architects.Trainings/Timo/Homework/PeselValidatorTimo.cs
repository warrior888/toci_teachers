using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using Toci.Architects.Training.GhostRider.BasicGenerics;
using Toci.Architects.Training.Interfaces.GhostRider.Extending.PeselValidator;

namespace Toci.Architects.Training.Timo.Homework
{
    public class PeselValidatorTimo : IPeselValidator, IReflectionAggregator
    {
        public string Name()
        {
            return "Timo";
        }

        public bool IsPeselValid(string pesel)
        {
            int[] importance = {9,7,3,1,9,7,3,1,9,7};
            int checkSum = 0;
            long result;

            if (!long.TryParse(pesel, out result))
            {
                return false;
            }

            for (int i = 0; i < pesel.Length - 1; i++)
            {
               checkSum += int.Parse(pesel.Substring(i, 1)) * importance[i]; //"49040501580"

            }
            checkSum = checkSum % 10;
            return checkSum == int.Parse(pesel.Substring(10,1));
        }

        public Dictionary<string, IPeselValidator> GetAllPeselValidators()
        {
            Dictionary<string, IPeselValidator> dictionaryValidators = new Dictionary<string, IPeselValidator>();

            Type[] allTypesInAssembly = Assembly.GetExecutingAssembly().GetTypes();
            Type seekedForType = typeof(IPeselValidator);

            IEnumerable<Type> derivingTypes = allTypesInAssembly.Where(m => seekedForType.IsAssignableFrom(m));

            foreach (var derivingType in derivingTypes)
            {
                IPeselValidator item = (IPeselValidator)Activator.CreateInstance(derivingType);
                dictionaryValidators.Add(item.Name(), item);
            }

            return dictionaryValidators;
        }
    }
}