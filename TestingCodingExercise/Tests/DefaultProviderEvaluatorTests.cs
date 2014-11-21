using NUnit.Framework;

namespace TestingCodingExercise
{
    internal class DefaultProviderEvaluatorTests: AbstractProviderEvaluatorTests<DefaultProviderEvaluator>
    {
        [TestCase(0, true, @"0")]
        [TestCase(1, true, @"1")]
        [TestCase(2, true, @"2")]
        [TestCase(3, true, @"3")]
        [TestCase(4, true, @"4")]
        [TestCase(5, true, @"5")]
        [TestCase(6, true, @"6")]
        [TestCase(7, true, @"7")]
        [TestCase(8, true, @"8")]
        [TestCase(9, true, @"9")]
        public override void VerifyThatValueYieldsText(int value, bool expectedResult, string expectedText)
        {
            base.VerifyThatValueYieldsText(value, expectedResult, expectedText);
        }
    }
}