using Gardenalogue.Service;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var sut = new Class1();
            Assert.IsTrue(sut.Method1());
        }
    }
}