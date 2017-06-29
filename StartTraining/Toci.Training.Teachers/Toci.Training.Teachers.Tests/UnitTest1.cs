using System;
using System.Diagnostics;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Toci.Training.Teachers.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Process.Start(@"..\..\..\Toci.Training.Kafar\bin\Debug\Toci.Training.Kafar.exe");
            string path =
                @"C:\Users\mlote\Documents\GitHub\toci_teachers\StartTraining\Toci.Training.Teachers\Toci.Training.Kafar\bin\Debug\Toci.Training.Kafar.exe";
            const string exe = "Toci.Training.Kafar.exe";
            var exePath = System.IO.Path.GetFullPath(exe);
            var universalPath = System.IO.Path.GetDirectoryName(path);
            ProcessStartInfo testProcessStartInfo = new ProcessStartInfo();


            string test = Process.GetCurrentProcess().Modules.ToString();
        }
    }
}
