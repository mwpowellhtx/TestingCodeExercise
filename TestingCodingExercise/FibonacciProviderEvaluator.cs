using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestingCodingExercise
{
    internal class FibonacciProviderEvaluator : IProviderEvaluator
    {
        public bool TryEvaluate(int value, TextWriter writer)
        {
            var tried = FibonacciSequence(value).ToArray().Contains(value);
            if (tried) writer.Write(@"Gem");
            return tried;
        }

        private static IEnumerable<int> FibonacciSequence(int max)
        {
            var a = 0;
            var b = 1;
            while (a <= max)
            {
                yield return a + b;
                var c = a + b;
                a = b;
                b = c;
            }
        }
    }
}
