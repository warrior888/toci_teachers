using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Toci.Architects.Training.Interfaces.GhostRider.Inheritance;

namespace Toci.Architects.Training.GhostRider.ComplexPolimorphismTest
{
    public class ComplexPolimorphism
    {
        public List<ICsprojPropagator> GetAllDerivingTypes()
        {
            Type[] allTypesInAssembly = Assembly.GetExecutingAssembly().GetTypes(); //.Where()

            Type seekedForType = typeof (ICsprojPropagator);

            Type kafar = typeof (Kafar.Inheritance.InheritanceKafar2);

            //seekedForType.

            //allTypesInAssembly[0].IsAssignableFrom()

            IEnumerable<Type> derivingTypes = allTypesInAssembly.Where(m => seekedForType.IsAssignableFrom(m));

            return null;
        }
    }
}