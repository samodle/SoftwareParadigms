using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace AdvancedSoftwareParadigms
{
    class PrintNameSizeRange
    {
        static void PrintTypeInfo()
        {
            /*
             * 
             * Note: List of Built in Types used for this program came from: 
             * https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
             * 
             */

            Console.WriteLine("Print Size, Type, and Range");
            Console.WriteLine();

            var basicTypeList = getTypeList();

            foreach (object t in basicTypeList)
            {
                Console.WriteLine(getInfoString(t.GetType()));
            }
        }
        private static string getInfoString(Type o)
        {
            var sizeInBytes = Marshal.SizeOf(o);
            var name = o.ToString();

            dynamic minVal;
            dynamic maxVal;

            var sizeInBits = sizeInBytes * 8;

            if (name.Contains("U") || name.Equals("System.Byte"))
            { //perhaps inelegant, but it's valid for this application. see docs refernced above
                minVal = 0;
                maxVal = Math.Pow(2, sizeInBits) - 1;
            }
            else
            {
                minVal = Math.Pow(2, sizeInBits - 1) * -1;
                maxVal = Math.Pow(2, sizeInBits - 1) - 1;
            }

            return (o.ToString() + ", Size in Bytes: " + sizeInBytes + ", Range: " + minVal + " to " + maxVal);
        }

        private static List<object> getTypeList()
        {
            return new List<object>() { new bool(), new byte(), new sbyte(), new char(), new decimal(), new double(), new float(), new int(), new uint(), new long(), new ulong(), new short(), new ushort() };
        }
    }
}
