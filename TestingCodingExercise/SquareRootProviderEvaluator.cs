using System;
using System.IO;

namespace TestingCodingExercise
{
    internal class SquareRootProviderEvaluator : IProviderEvaluator
    {
        public bool TryEvaluate(int value, TextWriter writer)
        {
            var sqrt = Math.Sqrt(value);
            var untried = Math.Abs(sqrt - (int) sqrt) > 0d;
            if (!untried) writer.Write(@"Quartz");
            return !untried;
        }
    }
}
