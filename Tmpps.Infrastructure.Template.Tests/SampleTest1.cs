using NUnit.Framework;
using Tmpps.Infrastructure.Template;

namespace Tests
{
    public class Tests
    {
        [TestCaseSource(nameof(GetHelloTestParameters))]
        public void GetHelloTest(string name, string expected)
        {
            var sample = new Sample();
            var actual = name == null ? sample.GetHello() : sample.GetHello(name);
            Assert.AreEqual(expected, actual);
        }
        static object[] GetHelloTestParameters = {
            new object[] { null, "Hello world." },
            new object[] { "tmpps", "Hello tmpps." },
        };
    }
}