namespace HelloWorld.Tests
{
    using NUnit.Framework;
    using System.ComponentModel.Composition;
    using System.ComponentModel.Composition.Hosting;

    [TestFixture]
    public class UnitTestMef
    {
        public interface IClass<T>
        {
            string Execute();
        }

        [Export(typeof(IClass<>))]
        public class ImplementedClass<T> : IClass<T>
        {
            public string Execute()
            {
                return "Class was imported and executed successfully";
            }
        }

        [TestFixture]
        public class ClassSpecs
        {
            [Test]
            public void ClassShouldBeImported()
            {
                var catalog = new AssemblyCatalog(typeof(ImplementedClass<string>).Assembly);
                var container = new CompositionContainer(catalog);
                var importedInstance = container.GetExportedValue<IClass<string>>();

                Assert.That(importedInstance.Execute(), Is.EqualTo("Class was imported and executed successfully"));
            }
        }
    }
}
