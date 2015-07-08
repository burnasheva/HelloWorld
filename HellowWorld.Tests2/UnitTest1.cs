using System;

using NUnit.Framework;

namespace HelloWorld.Tests
{
    [TestFixture]
    [Parallelizable]
    public class UnitTest1
    {
        private static readonly Random Rnd = new Random();

        [Test]
        [Parallelizable]
        public void TestDo()
        {
            var a = new Class1();
            a.Do();
        }
    }
}
