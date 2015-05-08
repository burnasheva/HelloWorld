namespace HelloWorld.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethodSuccess()
        {
        }

        [Test]
        public void TestMethodFail()
        {
            Assert.Fail("Some reason");
        }


        [Test, Category("A")]
        public void TestMethodCatA()
        {
        }

        [Test, Category("B")]
        public void TestMethodCatB()
        {
        }
    }
}
