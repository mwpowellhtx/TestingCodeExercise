using NUnit.Framework;

namespace TestingCodingExercise
{
    internal class FizzProviderEvaluatorTests : AbstractProviderEvaluatorTests<FizzProviderEvaluator>
    {
        [TestCase(0, true, @"Fizz")]
        [TestCase(1, false, @"")]
        [TestCase(2, false, @"")]
        [TestCase(3, true, @"Fizz")]
        [TestCase(4, false, @"")]
        [TestCase(5, false, @"")]
        [TestCase(6, true, @"Fizz")]
        [TestCase(7, false, @"")]
        [TestCase(8, false, @"")]
        [TestCase(9, true, @"Fizz")]
        [TestCase(10, false, @"")]
        [TestCase(11, false, @"")]
        [TestCase(12, true, @"Fizz")]
        public override void VerifyThatValueYieldsText(int value, bool expectedResult, string expectedText)
        {
            base.VerifyThatValueYieldsText(value, expectedResult, expectedText);
        }
    }
}