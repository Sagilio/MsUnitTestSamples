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
    [AllureSubSuite("Example")]
    [AllureSeverity(SeverityLevel.critical)]
    public class Tests
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
            const int j = 6;
            const int result = 11;

            var output = await Counter.Add(i, j);
            Assert.AreEqual(result, output);
        }
    }
}