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
                Console.WriteLine($"{newVal} selected.");

                switch (newVal)
                {
                    case "a":
                        var tempShapeMgra = new ShapeManager<Triangle>(new Triangle());
                        tempShapeMgra.MyShape.ParameterValues = tempShapeMgra.CollectParameters();
                        if(tempShapeMgra.MyShape.GetArea() > 0)
                            Console.WriteLine($"Area: {tempShapeMgra.MyShape.GetArea()} ft^2");
                        break;

                    case "b":
                        var tempShapeMgrb = new ShapeManager<Rectangle>(new Rectangle());
                        tempShapeMgrb.MyShape.ParameterValues = tempShapeMgrb.CollectParameters();
                        if (tempShapeMgrb.MyShape.GetArea() > 0)
                            Console.WriteLine($"Area: {tempShapeMgrb.MyShape.GetArea()} ft^2");
                        break;

                    case "c":
                        var tempShapeMgrc = new ShapeManager<Square>(new Square());
                        tempShapeMgrc.MyShape.ParameterValues = tempShapeMgrc.CollectParameters();
                        if (tempShapeMgrc.MyShape.GetArea() > 0)
                            Console.WriteLine($"Area: {tempShapeMgrc.MyShape.GetArea()} ft^2");
                        break;

                    case "d":
                        var tempShapeMgrd = new ShapeManager<Circle>(new Circle());
                        tempShapeMgrd.MyShape.ParameterValues = tempShapeMgrd.CollectParameters();
                        if (tempShapeMgrd.MyShape.GetArea() > 0)
                            Console.WriteLine($"Area: {tempShapeMgrd.MyShape.GetArea()} ft^2");
                        break;

                    case "e":
                        var tempShapeMgre = new ShapeManager<Parallelogram>(new Parallelogram());
                        tempShapeMgre.MyShape.ParameterValues = tempShapeMgre.CollectParameters();
                        if (tempShapeMgre.MyShape.GetArea() > 0)
                            Console.WriteLine($"Area: {tempShapeMgre.MyShape.GetArea()} ft^2");
                        break;

                    case "f":
                        Console.WriteLine("f selected. program terminating.");
                        finished = true; //terminate program
                        break;

                    default: //input not understood. prompt user to try again
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input. Please type 'a', 'b', 'c', 'd', 'e', or 'f'.");
                        Console.WriteLine();
                        break;
                }
            }
        }

        private class ShapeManager<T> 
        {
            public T MyShape;

            public ShapeManager(T shape)
            {
                MyShape = shape;
            }

            public List<double> CollectParameters()
            {
                var newList = new List<double>();

                foreach(string s in MyShape.ToString().Split(","))
                {
                    if(s.Trim().Length > 1)
                    {
                        Console.WriteLine($"Please enter non-zero positive value for {s}:");
                        var val = Console.ReadLine();
                        double d;
                        while (!double.TryParse(val, out d))
                        {
                            Console.WriteLine($"Invalid entry: {val}. Please enter non-zero positive value for {s}:");
                            val = Console.ReadLine();
                        }
                        newList.Add(d);
                    }
                }

                return newList;
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

