using System;
using System.Collections.Generic;

namespace Toci.Teachers.Checkmate.Interfaces
{
    public class Graph : Dictionary<Graph, Graph>
//Dictionary<string, Dictionary<string, string>>
    {
        protected int VisitCount;

        public string Name;

        public Dictionary<string, Graph> Neighbours = new Dictionary<string, Graph>();

        public virtual void AddNeighbour( Graph graph)
        {
            Graph newOne = Neighbours.ContainsKey(graph.Name) ? Neighbours[graph.Name] : new Graph();
            newOne.Add(graph, graph);
            Neighbours.Add(graph.Name, newOne);
        }

        //public Dictionary<string, Dictionary<string, Dictionary<>>>

    }

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
        // 
    }

    public class Woman<TWallet, TTAlent> : IWoman<TWallet, TTAlent> where TWallet : IWallet
    {
        public bool WantsToPee()
        {
            ///TWallet t = new TWallet();
            //t.IsRich();
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

    public static class HumanExtensions
    {
        public static bool WasBirthSuccessfull(this IWoman<IWallet, string> woman)
        {
            return true;
        }
    }

    public class Woman : IWoman<IWallet, string>
    {

        public bool WantsToPee()
        {
            
            throw new System.NotImplementedException();
        }
    }


    public class ThisIsForLEon
    {
        public void dummy()
        {
            Woman<IWallet, string> w = new Woman<IWallet, string>();

            w.WantsToPee();

            w.WasBirthSuccessfull();

            List<string> dafaq = new List<string>();

            dafaq.Add("leon");

        }
    }

    public interface IOperation
    {
        string Read();
    }

    public abstract class OperationBase : IOperation
    {
        public string Read()
        {
            throw new NotImplementedException();
        }

        public abstract bool SaveData(string whatever);
    }

    public class XmlOperation : OperationBase
    {
        public override bool SaveData(string whatever)
        {
            OperationBase fds = new XmlOperation();
            throw new NotImplementedException();
        }
    }
}

