using ClassLibrary1;

using NUnit.Framework;

namespace HelloWorld.Tests
{
    public class UnitTest2
    {
        private SomeClass _class;

        [SetUp]
        public void SetUp()
        {
            _class = new SomeClass();
        }

        [Test, Category("SE")]
        public void TestMethodSetUpFailed()
        {
        }
    }
}
