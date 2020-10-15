using System;
using System.Collections.Generic;

namespace AdvancedSoftwareParadigms
{
    public abstract class Shape
    {
        public abstract double GetArea();
        protected const int INVALID_AREA = -1;
        public abstract List<string> ParameterNames();
        public List<double> ParameterValues { get; set; } = new List<double>(); //per guidelines, assume unit is ft for all
        protected bool ValidateParameters()
        {
            if (ParameterValues.Count != ParameterNames().Count)
            {
                Console.WriteLine($"Incorrect Number Of Input Parameters.  Expected {ParameterNames().Count} but received {ParameterValues.Count}.");
                return false;
            }
            else //correct # parameters
            {
                for (int i = 0; i < ParameterValues.Count; i++)
                {
                    if (ParameterValues[i] <= 0)
                    {
                        Console.WriteLine($"Invalid Parameter - {ParameterNames()[i]}: {ParameterValues[i]}.  All parameters must be > 0.");
                        return false;
                    }
                }
            }
            return true; // passed all checks
        }

        //Please let the record show that while this hurts my soul it does enable a clever implementation of ADTs in the other file
        public override string ToString()
        {
            var dimensionParameters = ParameterNames();
            string s = "";
            for (int i = 0; i < dimensionParameters.Count; i++)
            {
                s += dimensionParameters[i];
                if (i != i - 1)
                    s += ",";
            }
            return s;
        }
    }

    public class Triangle : Shape
    {
        public override List<string> ParameterNames()
        {
            return new List<string> { "base", "height" };
        }

        //returns -1 if invalid area
        public override double GetArea()
        {
            if (ValidateParameters())
                return ParameterValues[0] * ParameterValues[1] / 2;
            else
                return INVALID_AREA;
        }
    }

    public class Parallelogram : Shape
    {
        public override List<string> ParameterNames()
        {
            return new List<string> { "base", "height" };
        }

        public override double GetArea()
        {
            if (ValidateParameters())
                return ParameterValues[0] * ParameterValues[1];
            else
                return INVALID_AREA;
        }
    }

    public class Rectangle : Parallelogram
    {
        public override List<string> ParameterNames()
        {
            return new List<string> { "length", "width" };
        }
    }

    public class Square : Rectangle
    {
        public override List<string> ParameterNames()
        {
            return new List<string> { "side" };
        }

        public override double GetArea()
        {
            if (ValidateParameters())
                return ParameterValues[0] * ParameterValues[0];
            else
                return INVALID_AREA;
        }
    }


    public class Circle : Shape
    {
        public override List<string> ParameterNames()
        {
            return new List<string> { "radius" };
        }

        public override double GetArea()
        {
            if (ValidateParameters())
                return Math.PI * ParameterValues[0] * ParameterValues[0];
            else
                return INVALID_AREA;
        }
    }
}
