using System;

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
            Assert.Fail("Is64BitProcess={0}", Environment.Is64BitProcess);
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
