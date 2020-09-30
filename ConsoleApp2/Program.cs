using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ConsoleApp2
{
    class Program
    {
        private static Random rand = new Random(); //generating random inputes

        static void Main(string[] args)
        {
            Console.WriteLine("CSCI 6221 - Homework #4 - Sam Odle");
            Console.WriteLine();



        }

        //for two non-zero, positive integers, return prime #s between the inputs
        private List<int> getPrimesInInterval(int lowerBound, int upperBound)
        {
            Console.WriteLine($"> Print Prime: {lowerBound}, {upperBound}");
            var primeList = new List<int>();

            //if inputs are negative, 0, or equal, return empty list
            if (lowerBound <= 0 || upperBound <= 0 || lowerBound == upperBound) { return primeList; }
            //if upperBound is smaller, swap bounds
            else if (upperBound < lowerBound)
            {
                var tmp = lowerBound;
                lowerBound = upperBound;
                upperBound = tmp;
            }

            //bounds are valid, let's find some prime numbers
            for (int i = lowerBound + 1; i < upperBound; i++)
            {
                if (isPrime(i))
                {
                    primeList.Add(i);
                }
            }

            return primeList;
        }

        //assumes input > 1, returns if number is prime
        private static bool isPrime(int testNumber)
        {
            for (int i = 1; i < testNumber; i++)
            {
                if (testNumber % i == 0) { return false; }
            }
            Console.WriteLine($"{testNumber} is a prime number.");
            return true; //number is prime, not divisible my numbers < it
        }

    }
}
