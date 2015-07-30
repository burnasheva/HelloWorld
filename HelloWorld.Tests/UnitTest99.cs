using NUnit.Framework;

namespace HelloWorld.Tests
{
    using JetBrains.dotMemoryUnit;

    [TestFixture]
    [Parallelizable]
    public class UnitTest99
    {
        [Test, Category("99")]
        [AssertTraffic(AllocatedSizeInBytes = 1000)]
        public void TestMethodSuccess()
        {
            dotMemory.Check(
                memory =>
                {
                    var a = new Class1();
                    a.Do();
                    Assert.AreEqual(10, memory.ObjectsCount);
                });
        }
    }
}
