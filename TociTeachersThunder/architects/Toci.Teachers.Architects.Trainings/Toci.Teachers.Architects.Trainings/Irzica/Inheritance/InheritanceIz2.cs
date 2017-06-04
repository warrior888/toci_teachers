using Toci.Architects.Training.Interfaces.GhostRider.Inheritance;

namespace Toci.Architects.Training.Irzica.Inheritance
{
    public class InheritanceIz2 : ICsprojPropagator
    {
        public void SendCharacter(int position, string text)
        {
            throw new System.NotImplementedException();
        }

        public bool CanPropagateCsproj(string path)
        {
            return false;
        }
    }
}