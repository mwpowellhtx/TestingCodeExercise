using System.Collections.Generic;
using System.IO;

namespace TestingCodingExercise
{
    internal interface IFizzProvider
    {
        void DoFizz(IEnumerable<int> range, TextWriter writer);
    }
}
