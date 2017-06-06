using System.Collections.Generic;
using Toci.Architects.Training.anaxagore78.Inheritance;
using Toci.Architects.Training.Interfaces.GhostRider.Inheritance;
using Toci.Architects.Training.Irzica.Inheritance;
using Toci.Architects.Training.Kafar.Inheritance;
using Toci.Architects.Training.Piotrek.Inheritance;
using Toci.Architects.Training.Timo.Inheritance;

namespace Toci.Architects.Training.GhostRider.SimpleCaseTestPolimorphism
{
    public class SimplePolimfphic
    {
         protected Dictionary<string, ICsprojPropagator> Map = new Dictionary<string, ICsprojPropagator>
         {
             { "Arek", new CanPropagateAnaxagore78()},
             { "Iza", new InheritanceIz2()},
             { "Daria", new CsProjDaria()},
             { "Mateusz", new InheritanceKafar2()},
             { "Piotrek", new InheritancePiotrek()},
         };

        public void Twsst()
        {
            foreach (var element in Map)
            {
                element.Value.CanPropagateCsproj("");
            }
        }
    }
}