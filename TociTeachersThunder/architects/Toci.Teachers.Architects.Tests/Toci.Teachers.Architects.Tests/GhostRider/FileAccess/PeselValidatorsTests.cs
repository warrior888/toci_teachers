using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Toci.Teachers.Architects.Tests.GhostRider.FileAccess
{
    [TestClass]
    public class PeselValidatorsTests
    {
        protected virtual List<string> GetFileContents()
        {
            string path = @"..\..\..\..\Toci.Teachers.Architects.Tests\Toci.Teachers.Architects.Tests\GhostRider\FileAccess\data\peselcandidates.txt";

            StreamReader sr = new StreamReader(path);

            sr.ReadToEnd();

            // split liste itd

            return null;
        }

        [TestMethod]
        public void PeselValidationTest()
        {
            GetFileContents();
        }
    }
}