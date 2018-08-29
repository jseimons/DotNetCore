using System;
using System.Collections;
using System.Collections.Generic;

using ClassLibrary.ExtensionMethods;
using ClassLibrary.ProjectEuler;

namespace ConsoleApp
{
    class Program
    {
        public static IList<int> GetSequence(int start)
        {
            // n → n/2 (n is even)
            // n → 3n + 1 (n is odd)

            var sequence = new List<int> { start };

            while (start > 1)
            {
                if (start % 2 == 0)
                    start = start / 2;
                else
                    start = start * 3 + 1;

                sequence.Add(start);
            }
            
            return sequence;
        }

        static void Main(string[] args)
        {
            // COLLATZ
            // int num     = -1;
            // int length  = -1;

            // for (int i = 1_000_00; i >= 1; i--)
            // {
            //     int sequenceLength = GetSequence(i).Count;
            //     if (sequenceLength > length) 
            //     {
            //         num     = i;
            //         length  = sequenceLength;
            //     }
            // }
            // Console.WriteLine($"{num}: {length}");

            int sumSquares = 1.SumSquares(100);
            int squareSum  = 1.SquareSum(100);

            Console.WriteLine($"{sumSquares} - {squareSum} - {squareSum - sumSquares}");

            Console.WriteLine("Hello, world!");
        }
    }
}
