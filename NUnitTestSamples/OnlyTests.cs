using System;
using System.Threading;
using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace NUnitTestSamples
{
    [AllureNUnit]
    public class OnlyTests
    {
        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("Hello, this is TestClass1 setUp");
        }

        [Test(Description = "Sample")]
        [AllureTag("TC-1")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("unickq")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        [AllureSubSuite("Simple")]      
        public void SimpleTestPassed()
        {
            Console.WriteLine(DateTime.Now);
        }

        [Test]
        [Ignore("I'm just an ignored test")]
        public void SimpleTestIgnored1()
        {
        }

        [Test(Author = "unickq")]
        [Description("OLOLO")]
        [AllureSuite("FailedSuite")]
        [AllureSubSuite("DoesNotThrow")]
        [AllureLink("Google", "https://google.com")]
        public void SimpleTestFailed()
        {
            Console.WriteLine("Failed");
            Assert.DoesNotThrow(() =>
            {
                throw new Exception("I'm an exception");
            });
        }

        private readonly string[] _adeleSong =
        {
            "Hello, it's me",
            "I was wondering if after all these years you'd like to meet",
            "To go over everything",
            "They say that time's supposed to heal ya",
            "But I ain't done much healing"
        };

        [Test]
        [AllureEpic("Song")]
        [AllureSuite("Adele")]
        [AllureSubSuite("Hello")]
        public void TestWithSteps()
        {
            //Allure Steps Example
            foreach (var str in _adeleSong)
                AllureLifecycle.Instance.WrapInStep(() =>
                {
                    Thread.Sleep(100 * new Random().Next(1, 10));
                    Console.WriteLine(str + Environment.NewLine);
                }, str);
        }
    }
}