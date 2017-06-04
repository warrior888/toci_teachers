using System.Collections.Generic;

namespace Toci.Architects.Training.Interfaces.GhostRider.Extending.PeselValidator
{
    public interface IReflectionAggregator
    {
        Dictionary<string, IPeselValidator> GetAllPeselValidators(); // all IPeselValidator , IPeselValidator.Name() => Key, Value => IPeselValidator
    }
}