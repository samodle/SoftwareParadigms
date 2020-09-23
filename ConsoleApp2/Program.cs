using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Note: List of Built in Types used for this program came from: 
             * https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
             * 
             * Sam Odle 9/23/2020
             * 
             */

            Console.WriteLine("CSCI 6221 - Homework #3 - Sam Odle");
            Console.WriteLine();

            var basicTypeList = getTypeList();

            foreach(object t in basicTypeList)
            {
                Console.WriteLine(getInfoString(t.GetType()));
            }
        }

    }
}
