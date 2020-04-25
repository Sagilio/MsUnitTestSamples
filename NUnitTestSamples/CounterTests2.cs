using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System.Threading.Tasks;
using TestApps;

namespace NUnitTestSamples
{
    [TestFixture]
    [AllureNUnit]
    [AllureSubSuite("Counter_2")]
    [AllureSeverity(SeverityLevel.critical)]
    public class CounterTests2
    {
        private Counter Counter { get; } = new Counter();

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [AllureTag("NUnit","Debug")]
        [AllureIssue("GitHub#1", "https://github.com/unickq/allure-nunit")]
        [AllureFeature("Core")]
        public async Task ShouldAdd()
        {
            const int i = 5;
            const int j = 60;
            const int result = 65;

            var output = await Counter.Add(i, j);
            Assert.AreEqual(result + 200, output);
        }

        [Test]
        [AllureTag("NUnit","Debug")]
        [AllureIssue("GitHub#1", "https://github.com/unickq/allure-nunit")]
        [AllureFeature("Core")]
        public async Task ShouldCount()
        {
            const int i = 5;
            const int j = 60;
            const int result = 2;

            var output = await Counter.Count(i, j);
            Assert.AreEqual(result, output);
        }

        [Test]
        [AllureTag("NUnit","Debug")]
        [AllureIssue("GitHub#1", "https://github.com/unickq/allure-nunit")]
        [AllureFeature("Core")]
        public async Task ShouldAddByCount()
        {
            const int i = 5;
            const int j = 60;
            const int result = 5;

            var output = await Counter.AddByCount(1,i, j);
            Assert.AreEqual(result, output);
        }
    }
}