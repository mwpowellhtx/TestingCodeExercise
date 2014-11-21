using System;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TestingCodingExercise
{
    [TestFixture]
    class FizzTests
    {
        private StringBuilder _builder;
        private TextWriter _writer;

        [SetUp]
        public void SetUp()
        {
            _builder = new StringBuilder();
            _writer = new StringWriter(_builder);
        }

        [TearDown]
        public void TearDown()
        {
            _writer.Close();
            _writer.Dispose();
        }

        [Test]
        [TestCase(1, 10, @"Fizz", 3)]
        [TestCase(1, 10, @"Buzz", 2)]
        public void VerifyThatFizzAndBuzzProviderEvaluatorsPrint(int start,
            int count, string expectedText, int expectedCount)
        {
            var provider = new FizzProvider(
                new FizzProviderEvaluator(),
                new BuzzProviderEvaluator());

            provider.DoFizz(Enumerable.Range(start, count), _writer);

            var actualCount = _builder.ToString()
                .Split(new[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray()
                .Count(x => x.Equals(expectedText));

            Assert.That(actualCount, Is.EqualTo(expectedCount));
        }
    }
}
