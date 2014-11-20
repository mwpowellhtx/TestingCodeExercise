using System;
using System.Collections.Generic;
using System.IO;

namespace TestingCodingExercise
{
    class FizzProvider : IFizzProvider
    {
        public void DoFizz(IEnumerable<int> range, TextWriter writer)
        {
            foreach (var i in range)
            {
                if (i % 3 == 0)
                    writer.WriteLine("Fizz");
                else
                {
                    writer.WriteLine(i);
                }
            }
        }
    }
}