using System;

using NUnit.Framework;
using System.Configuration;

namespace HelloWorld.Tests
{
    [TestFixture]
    public class UnitTestConfig
    {
        private static readonly Random Rnd = new Random();

        [Test]
        [Category("TW42399")]
        public void TestMethodConfig()
        {
            Console.Write(System.IO.Path.GetFileName(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile));
            var message = ConfigurationManager.AppSettings["TestMessage"];
            Assert.IsNotNull(message);
            Assert.AreEqual("Test message", message);
        }
    }
}
