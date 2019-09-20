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

        [Test]
        public void Test2()
        {
            var sut = new Class1();
            Assert.IsFalse(sut.Method2());
        }
    }
}