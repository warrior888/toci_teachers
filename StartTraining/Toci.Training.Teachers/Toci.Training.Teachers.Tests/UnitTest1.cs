using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Toci.Training.Teachers.Tests
{
    [TestClass]
    public class UnitTest1
    {
        List<string> paths = new List<string>();
        List<string> temp = new List<string>();
        const string origin = @"..\..\..\";

        private void CloneTempToPath()
        {
            paths.Clear();
            paths = temp.ToList();
            temp.Clear();
        }

        private void RunAllExe()
        {
            paths = Directory.GetDirectories(origin).ToList();

            foreach (string path in paths)
            {
                if (path.Contains("Toci"))
                {
                    temp.Add(path);
                }
            }

            CloneTempToPath();

            foreach (string path in paths)
            {
                string[] foldersInToci = Directory.GetDirectories(path);
                foreach (string folder in foldersInToci)
                {
                    if (folder.Contains("bin"))
                    {
                        temp.Add(folder);
                    }

                }

            }

            CloneTempToPath();

            foreach (string path in paths)
            {
                string[] foldersInBin = Directory.GetDirectories(path);
                foreach (string folder in foldersInBin)
                {
                    if (folder.Contains("Debug"))
                    {
                        temp.Add(folder);
                    }

                }

            }

            CloneTempToPath();

            foreach (string path in paths)
            {
                string[] filesInDebug = Directory.GetFiles(path);
                foreach (string file in filesInDebug)
                {
                    if (file.EndsWith("exe"))
                    {
                        temp.Add(file);
                    }
                }

            }

            CloneTempToPath();

            foreach (string path in paths)
            {
                Process.Start(path);
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            RunAllExe();

        }
    }
}
