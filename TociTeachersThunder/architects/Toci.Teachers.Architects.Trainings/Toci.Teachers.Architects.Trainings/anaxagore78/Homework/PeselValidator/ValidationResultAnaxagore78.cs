using System.Collections.Generic;

namespace Toci.Architects.Training.anaxagore78.Homework.PeselValidator
{
    public class ValidationResultAnaxagore78
    {
        public int Validated { get; set; }
        public int NotValidated { get; set; }
        public Dictionary<string, int> Exceptions { get; set; } = new Dictionary<string, int>();
        public string ExecutionTime { get; set; }

    }
}