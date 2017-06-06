using Toci.Architects.Training.Interfaces.GhostRider.Inheritance;

namespace Toci.Architects.Training.Kafar.Inheritance
{
    public class InheritanceKafar2 : ICsprojPropagator
    {
        //private int fieldKafar = 5;
        protected string Property { get; set; }

        public void SendCharacter(int position, string text)
        {
            throw new System.NotImplementedException();
        }

        public bool CanPropagateCsproj(string path)
        {
            throw new System.NotImplementedException();
        }
    }
}