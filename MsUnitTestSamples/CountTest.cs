using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using TestApps;

namespace MsUnitTestSamples
{
    [TestClass]
    public class CountTest
    {
        private Counter Counter { get; } = new Counter();

        [TestMethod]
        public async Task ShouldAdd()
        {
            const int i = 5;
            const int j = 6;
            const int result = 11;

            var output = await Counter.Add(i, j);
            Assert.AreEqual(result, output);
        }

        [TestMethod]
        public async Task ShouldCount()
        {
            const int i = 5;
            const int j = 6;
            const int result = 2;

            var output = await Counter.Count(i,j);
            Assert.AreEqual(result, output);
        }
    }
}
