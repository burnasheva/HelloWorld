using System;

using NUnit.Framework;

namespace HelloWorld.Tests
{
    public class UnitTest2
    {
        [SetUp]
        public void SetUp()
        {
            throw new Exception("SetUp exception");
        }

        [Test]
        public void TestMethodSetUpFailed()
        {
        }
    }
}
