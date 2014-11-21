using NUnit.Framework;

namespace TestingCodingExercise
{
    internal class BuzzProviderEvaluatorTests : AbstractProviderEvaluatorTests<BuzzProviderEvaluator>
    {
        [TestCase(0, true, @"Buzz")]
        [TestCase(1, false, @"")]
        [TestCase(2, false, @"")]
        [TestCase(3, false, @"")]
        [TestCase(4, false, @"")]
        [TestCase(5, true, @"Buzz")]
        [TestCase(6, false, @"")]
        [TestCase(7, false, @"")]
        [TestCase(8, false, @"")]
        [TestCase(9, false, @"")]
        [TestCase(10, true, @"Buzz")]
        [TestCase(11, false, @"")]
        [TestCase(12, false, @"")]
        public override void VerifyThatValueYieldsText(int value, bool expectedResult, string expectedText)
        {
            base.VerifyThatValueYieldsText(value, expectedResult, expectedText);
        }
    }
}
