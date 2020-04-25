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
    [AllureSubSuite("Counter_3")]
    [AllureSeverity(SeverityLevel.critical)]
    public class CounterTests3
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
            const int i = 50;
            const int j = 6;
            const int result = 56;

            var output = await Counter.Add(i, j);
            Assert.AreEqual(result, output);
        }

        [Test]
        [AllureTag("NUnit","Debug")]
        [AllureIssue("GitHub#1", "https://github.com/unickq/allure-nunit")]
        [AllureFeature("Core")]
        public async Task ShouldCount()
        {
            const int i = 50;
            const int j = 6;
            const int result = 1;

            var output = await Counter.Count(i, j);
            Assert.AreEqual(result, output);
        }

        [Test]
        [AllureTag("NUnit","Debug")]
        [AllureIssue("GitHub#1", "https://github.com/unickq/allure-nunit")]
        [AllureFeature("Core")]
        public async Task ShouldAddByCount()
        {
            const int i = 50;
            const int j = 6;
            const int result = 50;

            var output = await Counter.AddByCount(1,i, j);
            Assert.AreEqual(result, output);
        }
    }
}