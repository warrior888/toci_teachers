using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Architects.Training.Interfaces.GhostRider.Inheritance;

namespace Toci.Architects.Training.anaxagore78.Inheritance
{
    public class SendAnaxagore78: ICsprojPropagator
    {
        public void SendCharacter(int position, string text)
        {
            throw new NotImplementedException();
        }

        public bool CanPropagateCsproj(string path)
        {
            return true;
        }
    }
}
