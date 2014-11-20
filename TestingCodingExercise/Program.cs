using System;
using System.Linq;

namespace TestingCodingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = new FizzProvider(
                new FizzProviderEvaluator(),
                new BuzzProviderEvaluator(),
                new FibonacciProviderEvaluator(),
                new SquareRootProviderEvaluator());

            provider.DoFizz(Enumerable.Range(0, 100), Console.Out);
        }
    }
}
