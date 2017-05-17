using Framework.Components;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Example
{
    [TestClass]
    public class Tests
    {
        [TestInitialize]
        public void TestInitialize()
        {
        }

        [TestCleanup]
        public void TestCleanup()
        {
            DriverManager.Stop();
        }

        [TestMethod]
        public void TC_Example()
        {

        }
    }
}
