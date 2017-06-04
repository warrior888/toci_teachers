using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Architects.Training.GhostRider.Generics;

namespace Toci.Teachers.Architects.Tests.GhostRider.Generics
{
    [TestClass]
    public class GenericsExampleTests
    {
        [TestMethod]
        public void GenericListExampleTest()
        {
            List<int> intsList = new List<int>();
            List<string> stringsList = new List<string>();
            List<GenericsExampleTests> fun = new List<GenericsExampleTests>();

            intsList.Add(1);
            stringsList.Add("");
        }

        [TestMethod]
        public void ComplexDictionaryExampleTest()
        {
            ComplexDictionaryExample ex = new ComplexDictionaryExample();

            ex.Example();
        }

        public void ttt()
        {
            //Dictionary<Enum, Dictionary<string, GenericsExampleTests>>
            //    [enum][string]
        }
    }
}