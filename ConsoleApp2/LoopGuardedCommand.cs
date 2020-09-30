using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class LoopGuardedCommand
    {
        private static Random rand = new Random(); //used for non-deterministic execution below

        static void Main_LoopGuardedCommand(string[] args)
        {
            int rangeLow = 3; int rangeHigh = 6; int numerator = 12;
            for (int i = 0; i < 8; i++)
            {
                try
                {
                    Console.WriteLine($"Input: {rangeLow}, {rangeHigh}, {numerator}");
                    printFibonacciLGC(rangeLow, rangeHigh, numerator);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Program Terminated: {e.Message}");
                    Console.WriteLine();
                }

                //test for several random values
                rangeLow += rand.Next(1, 3);
                rangeHigh += rand.Next(2, 4);
                numerator += rand.Next(3, 6);
            }
        }

        private static void printFibonacciLGC(int rangeLow, int rangeHigh, int numerator)
        {
            var targetRange = Enumerable.Range(rangeLow, (rangeHigh - rangeLow + 1));
            var trueValues = new List<int>();

            //one boolean evaluation per integer in the range
            foreach (int value in targetRange)
            {
                if (numerator % value == 0) { trueValues.Add(value); }
            }

            //if no true values, throw runtime error
            if (trueValues.Count == 0) { throw new Exception($"Runtime Error - No Valid Values for {numerator}"); }

            int selectedOutcome;

            //if only one true value, use it
            if (trueValues.Count == 1) { selectedOutcome = trueValues[0]; }
            //otherwise, non-deterministically pick one
            else
            {
                //non-deterministically select one of the true cases
                selectedOutcome = trueValues[rand.Next(0, trueValues.Count)];
            }
            Console.WriteLine($"Selected Outcome: {selectedOutcome}");

            //print out the Fibonacci sequence for the selected case (fib #s < selected number)
            Console.Write($"Fibonacci Sequence: ");
            int i = 0;
            int fib_i = Fibonacci(i);
            while (fib_i < selectedOutcome)
            {
                Console.Write(fib_i + " ");
                i++;
                fib_i = Fibonacci(i);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

    }
}
}
