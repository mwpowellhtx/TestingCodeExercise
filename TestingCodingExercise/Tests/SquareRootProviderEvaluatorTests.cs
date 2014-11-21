using NUnit.Framework;

namespace TestingCodingExercise
{
    internal class SquareRootProviderEvaluatorTests : AbstractProviderEvaluatorTests<SquareRootProviderEvaluator>
    {
        [TestCase(0, true, @"Quartz")]
        [TestCase(1, true, @"Quartz")]
        [TestCase(2, false, @"")]
        [TestCase(3, false, @"")]
        [TestCase(4, true, @"Quartz")]
        [TestCase(5, false, @"")]
        [TestCase(6, false, @"")]
        [TestCase(7, false, @"")]
        [TestCase(8, false, @"")]
        [TestCase(9, true, @"Quartz")]
        [TestCase(10, false, @"")]
        [TestCase(11, false, @"")]
        public override void VerifyThatValueYieldsText(int value, bool expectedResult, string expectedText)
        {
            base.VerifyThatValueYieldsText(value, expectedResult, expectedText);
        }
    }
}
