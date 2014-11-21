using NUnit.Framework;

namespace TestingCodingExercise
{
    internal class FibonacciProviderEvaluatorTests : AbstractProviderEvaluatorTests<FibonacciProviderEvaluator>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="expectedResult"></param>
        /// <param name="expectedText"></param>
        /// <see cref="http://en.wikipedia.org/wiki/Fibonacci_number"/>
        [TestCase(0, false, @"")]
        [TestCase(1, true, @"Gem")]
        [TestCase(2, true, @"Gem")]
        [TestCase(3, true, @"Gem")]
        [TestCase(4, false, @"")]
        [TestCase(5, true, @"Gem")]
        [TestCase(6, false, @"")]
        [TestCase(7, false, @"")]
        [TestCase(8, true, @"Gem")]
        [TestCase(9, false, @"")]
        [TestCase(10, false, @"")]
        [TestCase(11, false, @"")]
        [TestCase(12, false, @"")]
        [TestCase(13, true, @"Gem")]
        [TestCase(14, false, @"")]
        public override void VerifyThatValueYieldsText(int value, bool expectedResult, string expectedText)
        {
            base.VerifyThatValueYieldsText(value, expectedResult, expectedText);
        }
    }
}
