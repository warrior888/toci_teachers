using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
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
            const string exe = "costam";
            string pathX = @"..\..\..\";
            string[] pathY = new string[50];
            string[] paths = new string[100];
            paths = Directory.GetDirectories(pathX);
            pathY = Directory.GetDirectories(paths[13]);
            //Directory.
            var exePath = Path.GetFullPath(exe);
            var universalPath = Path.GetDirectoryName(exePath);
            ProcessStartInfo testProcessStartInfo = new ProcessStartInfo();
            string path2 = Assembly.GetExecutingAssembly().Location;
            string path3 = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            

            string test = Process.GetCurrentProcess().Modules.ToString();
        }
    }
}
