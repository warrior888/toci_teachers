namespace Toci.Architects.Training.Interfaces.GhostRider.Extending
{
    public interface IBank
    {
        string Name { get; set; }

        void Transfer();
    }

    public interface IMbank : IBank
    {

    }

    public abstract class BankBase : IBank
    {
        public string Name { get; set; }
        public abstract void Transfer();

        protected bool IsSameCountry() //string country
        {
            return true;
        }

        protected bool HasTraveled(string country)
        {
            return true;
        }
    }
    public class MBank : BankBase, IMbank
    {
        public override void Transfer()
        {
            if (VerifySession())
            {
                
            }
        throw new System.NotImplementedException();
        }

        public bool VerifySession()
        {
            bool w = !IsSameCountry() && HasTraveled("");
            {
                return true;
            }
        }
    }
}