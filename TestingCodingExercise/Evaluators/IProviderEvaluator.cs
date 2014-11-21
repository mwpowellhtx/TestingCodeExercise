using System.IO;

namespace TestingCodingExercise
{
    internal interface IProviderEvaluator
    {
        /// <summary>
        /// Returns a string 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="writer"></param>
        /// <returns></returns>
        bool TryEvaluate(int value, TextWriter writer);
    }
}
