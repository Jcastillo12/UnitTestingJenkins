using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;
namespace pruebaunitaria
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World", Program.createMessage());
        }
    }
}
