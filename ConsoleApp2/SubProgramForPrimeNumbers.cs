using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedSoftwareParadigms
{
    class SubProgramForPrimeNumbers
    {
        private static Random rand = new Random(); //generating random inputes

        // for this assignment, I used the following Microsoft C# Docs:
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates

        private delegate List<int> MyDelegate(int lowerBound, int upperBound);

        static void Main_SubProgramsAndDelegates(string[] args)
        {
            //FYI for large numbers results were spot checked here: https://primes.utm.edu/curios/includes/primetest.php

            int numberOfTests = 10; //how many times will we check our function

            for (int i = 0; i < numberOfTests; i++)
            {
                int a = rand.Next(1, 1000);
                int b = rand.Next(1, 1000);

                MyDelegate primeDelegate = new MyDelegate(getPrimesInInterval);
                var tmpList = primeDelegate(a, b); //not necessary to return list, doing it to see how it works
            }

        }

        //for two non-zero, positive integers, return prime #s between the inputs
        private static List<int> getPrimesInInterval(int lowerBound, int upperBound)
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
            for (int i = 2; i < testNumber; i++)
            {
                if (testNumber % i == 0) { return false; }
            }
            Console.WriteLine($"{testNumber} is a prime number.");
            return true; //number is prime, not divisible my numbers < it
        }

    }
}
