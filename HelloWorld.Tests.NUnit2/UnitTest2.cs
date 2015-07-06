using System;

namespace HelloWorld.Tests.NUnit2
{
    using NUnit.Framework;

    [TestFixture]
    public class UnitTest2
    {
        [SetUp]
        public void TestSetUp()
        {
            throw new StackOverflowException("Init exception");
        }

        [Test]
        public void TestMethod1()
        {
        }
    }
}
