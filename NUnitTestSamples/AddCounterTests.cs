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
    [AllureSuite("AddCounter")]
    [AllureSeverity(SeverityLevel.critical)]
    public class AddCounterTests
    {
        private AddCounter Counter { get; } = new AddCounter();

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [AllureFeature("Core")]
        public async Task ShouldAdd()
        {
            const int i = 5;
            const int j = 6;
            const int result = 11;
            Console.WriteLine($"input values : i = {i} j = {j};");
            Console.WriteLine($"output except : result = {result};");

            var output = await Counter.AddAsync(i, j);
            Console.WriteLine($"output actual : result = {output};");

            Assert.AreEqual(result, output);
        }

        [Test]
        [AllureFeature("Core")]
        public async Task ShouldCount()
        {
            const int i = 5;
            const int j = 6;
            const int result = 2;
            Console.WriteLine($"input values : i = {i} j = {j};");
            Console.WriteLine($"output except : result = {result};");

            var output = await Counter.CountAsync(i, j);
            Console.WriteLine($"output actual : result = {output};");

            Assert.AreEqual(result, output);
        }

        [Test]
        [AllureFeature("Core")]
        public async Task ShouldAddByCount()
        {
            const int i = 5;
            const int j = 6;
            const int result = 5;
            Console.WriteLine($"input values : i = {i} j = {j};");
            Console.WriteLine($"output except : result = {result};");

            var output = await Counter.AddByCountAsync(1,i, j);
            Console.WriteLine($"output actual : result = {output + 1};");

            Assert.AreEqual(result, output + 1);
        }
    }
}