using System;
using System.Collections.Generic;

namespace Toci.Teachers.Checkmate.Interfaces
{
    public interface ITociTeachers
    {
        
    }

    // private protected public   internal

    public interface IHuman<out TWallet, TTalent> where TWallet : IWallet
    {
        bool WantsToPee();
    }

    //public class GFhostrider : IWoman<Dictionary<Func<string, Dictionary<>>>>

    public interface IWoman<TWallet, TTalent> : IHuman<IWallet, TTalent>
    {
        // dependency inj
    }

    public class Woman<TWallet, TTAlent> : IWoman<TWallet, TTAlent> where TWallet : IWallet
    {
        public bool WantsToPee()
        {
            TWallet t = new TWallet();
            t.IsRich();
            throw new NotImplementedException();
        }


        public virtual void leonisthebest()
        {
            
        }
    }

    public class TociWallet : IWallet
    {
        public bool IsRich()
        {
            throw new NotImplementedException();
        }
    }

    public class VeryRichWallet : IWallet
    {
        public bool IsRich()
        {
            IWallet dsadf = new TociWallet();
            IHuman<IWallet, string> leon = new Woman<TociWallet, string>();
            
            return true;
        }
    }

    //public interface IMan : IWoman
    //{
        
    //}

    public interface IWallet
    {
        bool IsRich();
    }

    interface IFaithfull
    {
        bool IWANTTOSEXYOU(bool isHusband);
    }

    class MojaZona<TRich, TSex> : IWoman<TRich, TSex> where TSex : IFaithfull
    {
        public bool WantsToPee()
        {
            throw new NotImplementedException();
        }
    }

    /*public static class HumanExtensions
    {
        public static bool WasBirthSuccessfull(this IWoman woman)
        {
            return true;
        }
    }

    public class Woman : IWoman
    {

        public bool WantsToPee()
        {
            
            throw new System.NotImplementedException();
        }
    }*/


    public class ThisIsForLEon
    {
        public void dummy()
        {
            

            w.WantsToPee();

            w.WasBirthSuccessfull();

            List<string> dafaq = new List<string>();

            dafaq.Add("leon");

        }
    }
}

