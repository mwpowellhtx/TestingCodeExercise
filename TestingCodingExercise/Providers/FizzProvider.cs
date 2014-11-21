using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestingCodingExercise
{
    class FizzProvider : IFizzProvider
    {
        private readonly IEnumerable<IProviderEvaluator> _evaluators;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="evaluators"></param>
        internal FizzProvider(params IProviderEvaluator[] evaluators)
        {
            _evaluators = evaluators;
        }

        public void DoFizz(IEnumerable<int> range, TextWriter writer)
        {
            var evaluator = new DefaultProviderEvaluator();

            foreach (var i in range)
            {
                if (!_evaluators.Select(e => e.TryEvaluate(i, writer)).ToArray().Any(x => x))
                    evaluator.TryEvaluate(i, writer);

                writer.WriteLine();
            }
        }
    }
}