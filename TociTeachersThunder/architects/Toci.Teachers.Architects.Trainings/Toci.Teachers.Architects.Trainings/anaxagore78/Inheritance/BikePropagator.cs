using Toci.Architects.Training.Interfaces.GhostRider.Inheritance;

namespace Toci.Architects.Training.anaxagore78.Inheritance
{
    public class BikePropagator: ICsprojPropagator
    {
        public void SendCharacter(int position, string text)
        {
            throw new System.NotImplementedException();
        }

        public bool CanPropagateCsproj(string path)
        {
            return true;
        }
    }
}