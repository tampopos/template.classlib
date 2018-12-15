using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tmpps.Infrastructure.Template;

namespace Tests
{
    [TestClass]
    public class Tests
    {
        [DataTestMethod]
        [DynamicData(nameof(GetHelloTestParameters), DynamicDataSourceType.Property)]
        public void GetHelloTest(string name, string expected)
        {
            var sample = new Sample();
            var actual = name == null ? sample.GetHello() : sample.GetHello(name);
            Assert.AreEqual(expected, actual);
        }
        static object[] GetHelloTestParameters => new []
        {
            new object[] { null, "Hello world2." },
            new object[] { "tmpps", "Hello tmpps2." },
        };
    }
}