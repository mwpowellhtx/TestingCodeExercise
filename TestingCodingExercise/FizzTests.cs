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
        [TestCase(1, 10, 3)]
        public void Given0To4ShouldWriteFizzFor0And3(int start, int count, int expectedFizz)
        {
            var provider = new FizzProvider();

            provider.DoFizz(Enumerable.Range(start, count), _writer);

            var actualFizz = _builder.ToString()
                .Split(new[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray()
                .Count(x => x.Equals(@"Fizz"));

            Assert.That(actualFizz, Is.EqualTo(expectedFizz));
        }
    }
}
