using System.IO;

namespace TestingCodingExercise
{
    internal class BuzzProviderEvaluator : IProviderEvaluator
    {
        public bool TryEvaluate(int value, TextWriter writer)
        {
            var tried = value%5 == 0;
            if (tried) writer.Write(@"Buzz");
            return tried;
        }
    }
}
