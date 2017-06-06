using NUnit.Framework;
using HelloJenkins;

namespace HelloJenkinsTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {

            Assert.AreEqual(Program.Test(), true);	
        }
    }
}
