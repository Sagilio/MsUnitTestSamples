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
    [AllureSuite("Counter_3")]
    [AllureSeverity(SeverityLevel.critical)]
    public class CounterTests3
    {
        private Counter Counter { get; } = new Counter();

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User1")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        public async Task ShouldAdd()
        {
            const int i = 50;
            const int j = 6;
            const int result = 56;

            var output = await Counter.Add(i, j);
            Assert.AreEqual(result, output);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User1")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        public async Task ShouldCount()
        {
            const int i = 50;
            const int j = 6;
            const int result = 1;

            var output = await Counter.Count(i, j);
            Assert.AreEqual(result, output);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User2")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
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