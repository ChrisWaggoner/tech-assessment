using NUnit.Framework;

namespace TestTest
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
            Assert.Pass();
        }

        [Test]
        public void TestGet()
        {
            CSharp.Controllers.Test TestTest = new CSharp.Controllers.Test();

            Assert.That(TestTest.Get(), Is.EqualTo("Success!"));



        }
    }
}