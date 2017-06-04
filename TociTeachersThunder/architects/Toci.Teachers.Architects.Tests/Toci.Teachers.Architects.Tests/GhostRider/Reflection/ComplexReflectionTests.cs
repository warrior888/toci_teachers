using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Architects.Training.GhostRider.ComplexPolimorphismTest;

namespace Toci.Teachers.Architects.Tests.GhostRider.Reflection
{
    [TestClass]
    public class ComplexReflectionTests
    {
        [TestMethod]
        public void ReflectionTest()
        {
            ComplexPolimorphism cPol = new ComplexPolimorphism();

            cPol.GetAllDerivingTypes();
        }
    }
}