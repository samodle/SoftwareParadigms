using System;
using System.Collections.Generic;

namespace AdvancedSoftwareParadigms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CSCI 6221 - Homework #6 - Sam Odle");

            bool finished = false;

            while (!finished)
            {
                PrintMenu();

                var newVal = Console.ReadLine();

                switch (newVal)
                {
                    case "a":
                        Console.WriteLine("a selected. please enter a new element for queue insertion:");
                    
                        break;

                    case "b":
                        Console.WriteLine("b selected. attempting to pop.");
                   
                        break;

                    case "c":
                        Console.WriteLine("c selected. total number of elements in queue:");
                     
                        break;

                    case "d":
                        Console.WriteLine("d selected. .");

                        break;

                    case "e":
                        Console.WriteLine("e selected. .");

                        break;

                    case "f":
                        Console.WriteLine("f selected. program terminating.");
                        finished = true; //terminate program
                        break;

                    default: //input not understood. prompt user to try againr
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input. Please type 'a', 'b', 'c', 'd', 'e', or 'f'.");
                        Console.WriteLine();
                        break;
                }
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Please Select A Shape By Typing The Corresponding Letter & Hitting Enter:");
            Console.WriteLine("a. triangle");
            Console.WriteLine("b. rectangle");
            Console.WriteLine("c. square");
            Console.WriteLine("d. circle");
            Console.WriteLine("e. parallelogram");
            Console.WriteLine("f. Exit");
            Console.WriteLine();
        }
    }
}

