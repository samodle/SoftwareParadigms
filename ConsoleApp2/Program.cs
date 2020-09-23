using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CSCI 6221 - Homework #3 - Sam Odle");
            Console.WriteLine();

            try
            {
                printFibonacciLGC(3, 6, 12);
            }
            catch(Exception e)
            {
                Console.WriteLine($"Program Terminated w/ Following Error Message: {e.Message}");
            }

        }

        private static void printFibonacciLGC(int rangeLow, int rangeHigh, int numerator)
        {
            var targetRange = Enumerable.Range(rangeLow, (rangeHigh - rangeLow + 1));
            var trueValues = new List<int>();

            //one boolean evaluation per integer in the range
            foreach(int value in targetRange)
            {
                if(numerator % value == 0) { trueValues.Add(value); }
            }

            if(trueValues.Count == 0) { throw new Exception($"Runtime Error - No Valid Values for {numerator}"); }

            //else there was at least one Boolean expression that evaluated true
            else
            {
                //non-deterministically select one of the true cases

                //print out the Fibonacci sequence for the selected case
            }
        }

    }
}
