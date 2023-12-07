using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Security.Cryptography.X509Certificates;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string res = CalculationsProject.Controllers.HomeController.testingStr();

            Assert.AreEqual("Comidas 130", res);
        }
    }
}