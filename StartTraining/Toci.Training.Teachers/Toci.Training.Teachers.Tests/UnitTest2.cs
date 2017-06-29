using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Toci.Training.Teachers.Tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            string filePathTemp = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            List<string> pathTab = filePathTemp.Split('\\').ToList();

            StringBuilder newPathStrBldr = new StringBuilder();
            for (int i = 0; i < pathTab.Count - 3; i++)
            {
                newPathStrBldr.Append(pathTab[i] + "\\");
            }

            string newPath = newPathStrBldr.ToString();
            string[] subdirectoryEntries = Directory.GetDirectories(newPath);

            List<string> exeFilePaths = new List<string>();

            for (int i = 0; i < subdirectoryEntries.Length; i++)
            {
                subdirectoryEntries[i] += @"\bin\debug\";
                if (!Directory.Exists(subdirectoryEntries[i])) continue;
                string[] fileEntries = Directory.GetFiles(subdirectoryEntries[i]);
                string exeFile = fileEntries.FirstOrDefault(file => file.EndsWith(".exe"));
                if (!string.IsNullOrEmpty(exeFile))
                    exeFilePaths.Add(exeFile);
            }


            foreach (var exeFile in exeFilePaths)
            {
                try
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo { FileName = exeFile };
                    using (Process exeProcess = Process.Start(startInfo))
                    {

                        exeProcess.WaitForExit();
                    }
                }
                catch
                {
                    // Log error.
                }
            }
        }
    }
}
