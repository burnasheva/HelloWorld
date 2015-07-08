using NUnit.Framework;

namespace HelloWorld.Tests2
{
    [TestFixture]
    [Parallelizable]
    public class UnitTest1
    {
        [Test]
        [Parallelizable]
        public void TestDo()
        {
            var a = new Class1();
            a.Do();
        }
    }
}
