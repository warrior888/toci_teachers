using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeterWinformsApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1 : ShuffleMethod
    {
        [TestMethod]
        public void TestMethod1()
        {
            Dictionary<string,int> dictionary=new Dictionary<string, int>();
            dictionary.Add("1",1);
            dictionary.Add("2",2);
            dictionary.Add("3",3);
            dictionary.Add("4",4);
            dictionary.Add("5",5);
            ShuffleMethod method = new ShuffleMethod();
            var sth = method.shuffle(dictionary, 10, 3);


        }
    }
}
