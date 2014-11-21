using System;
using System.IO;
using System.Text;
using NUnit.Framework;

namespace TestingCodingExercise
{
    internal abstract class AbstractProviderEvaluatorTests<TEvaluator>
        where TEvaluator : class, IProviderEvaluator, new()
    {
        /// <summary>
        /// Evaluator backing field.
        /// </summary>
        private readonly TEvaluator _evaluator = new TEvaluator();

        /// <summary>
        /// Evaluator fixture.
        /// </summary>
        private class EvaluatorFixture : IDisposable
        {
            private readonly StringBuilder _builder = new StringBuilder();

            private readonly StringWriter _writer;

            private readonly TEvaluator _evaluator;

            internal EvaluatorFixture(TEvaluator evaluator)
            {
                _evaluator = evaluator;
                _writer = new StringWriter(_builder);
            }

            public void Dispose()
            {
                _writer.Dispose();
            }

            internal void Verify(int value, bool expectedResult)
            {
                var actualResult = _evaluator.TryEvaluate(value, _writer);
                Assert.That(actualResult, Is.EqualTo(expectedResult));
            }

            public override string ToString()
            {
                return _builder.ToString();
            }
        }

        [Test]
        public virtual void VerifyThatValueYieldsText(int value, bool expectedResult, string expectedText)
        {
            using (var fixture = new EvaluatorFixture(_evaluator))
            {
                fixture.Verify(value, expectedResult);
                Assert.That(fixture.ToString(), Is.EqualTo(expectedText));
            }
        }
    }
}
