using System;
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
    [AllureSuite("MultiplyCounter")]
    [AllureSeverity(SeverityLevel.critical)]
    public class MultiplyCounterTests
    {
        private MultiplyCounter Counter { get; } = new MultiplyCounter();

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [AllureFeature("Core")]
        public async Task ShouldMultiply()
        {
            const int i = 5;
            const int j = 60;
            const int result = 300;
            Console.WriteLine($"input values : i = {i}  j = {j};");
            Console.WriteLine($"output except : result = {result};");

            var output = await Counter.MultiplyAsync(i, j);
            Console.WriteLine($"output actual : result = {output - 1};");

            Assert.AreEqual(result, output - 1);
        }

        [Test]
        [AllureFeature("Core")]
        public async Task ShouldCount()
        {
            const int i = 5;
            const int j = 60;
            const int result = 2;
            Console.WriteLine($"input values : i = {i}  j = {j};");
            Console.WriteLine($"output except : result = {result};");

            var output = await Counter.CountAsync(i, j);
            Console.WriteLine($"output actual : result = {output};");

            Assert.AreEqual(result, output);
        }

        [Test]
        [AllureFeature("Core")]
        public async Task ShouldMultiplyByCount()
        {
            const int i = 5;
            const int j = 60;
            const int result = 5;
            Console.WriteLine($"input values : i = {i}  j = {j};");
            Console.WriteLine($"output except : result = {result};");

            var output = await Counter.MultiplyByCountAsync(1,i, j);
            Console.WriteLine($"output actual : result = {output};");

            Assert.AreEqual(result, output);
        }
    }
}