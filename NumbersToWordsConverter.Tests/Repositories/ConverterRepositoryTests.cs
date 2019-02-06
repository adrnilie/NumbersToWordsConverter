using NumbersToWordConverter.Core;
using NumbersToWordsConverter.Services.Repositories;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace NumbersToWordsConverter.Tests.Repositories
{
    [TestFixture]
    public class ConverterRepositoryTests
    {
        private const string InvalidNumberMessage = "The entered number is invalid!";
        private IConverterRepository repoUnderTest;

        [TestCase("-0236", InvalidNumberMessage)]
        [TestCase("-.236", InvalidNumberMessage)]
        [TestCase(".0236", InvalidNumberMessage)]
        [TestCase(".-236", InvalidNumberMessage)]
        [TestCase("236-236", InvalidNumberMessage)]
        [TestCase(".236", InvalidNumberMessage)]
        [Test, TestCaseSource(nameof(Cases))]
        public void ConvertToWordsShouldReturnExpectedResult(string number, string expected)
        {
            // Arrange
            this.repoUnderTest = new ConverterRepository();

            // Act
            var actual = this.repoUnderTest.ConvertToWords(number).Result;

            // Assert
            Assert.AreEqual(actual, expected);
        }

        private static object[] Cases =
        {
            new object[] {"123", ConverterEntryPoint.ConvertNumbers("123")},
            new object[] {"4756", ConverterEntryPoint.ConvertNumbers("4756")},
            new object[] {"10256", ConverterEntryPoint.ConvertNumbers("10256")},
            new object[] {"1250256", ConverterEntryPoint.ConvertNumbers("1250256")},
            new object[] {"-1250256", $"Minus {ConverterEntryPoint.ConvertNumbers("1250256")}"}
        };
    }
}
