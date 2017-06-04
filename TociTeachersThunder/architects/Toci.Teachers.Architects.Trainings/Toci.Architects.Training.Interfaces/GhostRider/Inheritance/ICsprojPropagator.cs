namespace Toci.Architects.Training.Interfaces.GhostRider.Inheritance
{
    public interface ICsprojPropagator : IPlugin
    {
        bool CanPropagateCsproj(string path);
    }
}