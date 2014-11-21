using System.IO;

namespace TestingCodingExercise
{
    internal class FizzProviderEvaluator : IProviderEvaluator
    {
        public bool TryEvaluate(int value, TextWriter writer)
        {
            var tried = value%3 == 0;
            if (tried) writer.Write(@"Fizz");
            return tried;
        }
    }
}
