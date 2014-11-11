using System;
using System.Collections.Generic;
using System.Linq;

namespace TestingCodingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DoFizz(Enumerable.Range(0, 100));
        }

        private static void DoFizz(IEnumerable<int> range)
        {
            foreach (var i in range)
            {
                if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
