using System;
using System.Diagnostics;

namespace HelloWorld.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class UnitTest1
    {
        private static Random _rnd = new Random();

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

        [Test, Category("M")]
        public void TestMethodCatM01()
        {
            DoTest(1);
        }

        [Test, Category("M")]
        public void TestMethodCatM02()
        {
            DoTest(2);
        }

        [Test, Category("M")]
        public void TestMethodCatM03()
        {
            DoTest(3);
        }

        [Test, Category("M")]
        public void TestMethodCatM04()
        {
            DoTest(4);
        }

        [Test, Category("M")]
        public void TestMethodCatM05()
        {
            DoTest(5);
        }

        [Test, Category("M")]
        public void TestMethodCatM06()
        {
            DoTest(6);
        }

        [Test, Category("M")]
        public void TestMethodCatM07()
        {
            DoTest(7);
        }

        [Test, Category("M")]
        public void TestMethodCatM08()
        {
            DoTest(8);
        }

        [Test, Category("M")]
        public void TestMethodCatM09()
        {
            DoTest(9);
        }

        [Test, Category("M")]
        public void TestMethodCatM10()
        {
            DoTest(10);
        }

        private static void DoTest(int testId)
        {
            var testName = string.Format("Test {0}", testId);
            Console.WriteLine("Start test {0}", testName);
            System.Threading.Thread.Sleep(_rnd.Next(500));
            Console.WriteLine("Finish test {0}", testName);
        }
    }
}
