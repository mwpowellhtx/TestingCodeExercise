using System;
using System.Collections.Generic;
using System.Linq;

namespace TestingCodingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = new FizzProvider();
            provider.DoFizz(Enumerable.Range(0, 100), Console.Out);
        }
    }
}
