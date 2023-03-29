using System;

namespace LearningDotNetFramework
{
    public class Variables
    {
        public static void RunVars()
        {
            //Names can contain letters, digits and the underscore character (_)
            //Names must begin with a letter
            //Names should start with a lowercase letter and it cannot contain whitespace
            //Names are case sensitive ("myVar" and "myvar" are different variables)
            //Reserved words (like C# keywords, such as int or double) cannot be used as names
            
            // byte, sbyte, short, ushort, int, uint, long, ulong, float, double, char, decimal, bool, string
            byte byteVar = byte.MaxValue;
            byte byteVarMin = byte.MinValue;
            
            sbyte sByteVar = sbyte.MaxValue;
            sbyte sByteVarMin = sbyte.MinValue;
            
            short shortVar = short.MaxValue;
            short shortVarMin = short.MinValue;
            
            ushort uShortVar = ushort.MaxValue;
            ushort uShortVarMin = ushort.MinValue;
            
            int intVar = int.MaxValue;
            int intVarMin = int.MinValue;
            
            uint uIntVar = uint.MaxValue;
            uint uIntVarMin = uint.MinValue;
            
            long longVar = long.MaxValue;
            long longVarMin = long.MinValue;
            
            ulong uLongVar = ulong.MaxValue;
            ulong uLongVarMin = ulong.MinValue;
            
            float floatVar = float.MaxValue;
            float floatVarMin = float.MinValue;
            
            double doubleVar = double.MaxValue;
            double doubleVarMin = double.MinValue;
            
            char charVar = char.MaxValue;
            char charVarMin = char.MinValue;

            decimal decimalVar = decimal.MaxValue;
            decimal decimalVarMin = decimal.MinValue;
            
            bool boolVar = true;
            bool boolVarMin = false;

            string stringVar = "StringValue";
            
            // byte, sbyte, short, ushort, int, uint, long, ulong, float, double, char, decimal, bool, string
            Console.WriteLine("Max value of byte: {0}", byteVar.ToString());
            Console.WriteLine("Min value of byte: {0}", byteVarMin.ToString());
            Console.WriteLine("Max value of sbyte: {0}", sByteVar.ToString());
            Console.WriteLine("Min value of sbyte: {0}", sByteVarMin.ToString());
            Console.WriteLine("Max value of short: {0}", shortVar.ToString());
            Console.WriteLine("Min value of short: {0}", shortVarMin.ToString());
            Console.WriteLine("Max value of ushort: {0}", uShortVar.ToString());
            Console.WriteLine("Min value of ushort: {0}", uShortVarMin.ToString());
            Console.WriteLine("Max value of int: {0}", intVar.ToString());
            Console.WriteLine("Min value of int: {0}", intVarMin.ToString());
            Console.WriteLine("Max value of uint: {0}", uIntVar.ToString());
            Console.WriteLine("Min value of uint: {0}", uIntVarMin.ToString());
            Console.WriteLine("Max value of long: {0}", longVar.ToString());
            Console.WriteLine("Min value of long: {0}", longVarMin.ToString());
            Console.WriteLine("Max value of ulong: {0}", uLongVar.ToString());
            Console.WriteLine("Min value of ulong: {0}", uLongVarMin.ToString());
            Console.WriteLine("Max value of float: {0}", floatVar.ToString());
            Console.WriteLine("Min value of float: {0}", floatVarMin.ToString());
            Console.WriteLine("Max value of double: {0}", doubleVar.ToString());
            Console.WriteLine("Min value of double: {0}", doubleVarMin.ToString());
            Console.WriteLine("Max value of char: {0}", charVar.ToString());
            Console.WriteLine("Min value of char: {0}", charVarMin.ToString());
            Console.WriteLine("Max value of decimal: {0}", decimalVar.ToString());
            Console.WriteLine("Min value of decimal: {0}", decimalVarMin.ToString());
            Console.WriteLine("Max value of bool: {0}", boolVar);
            Console.WriteLine("Min value of bool: {0}", boolVarMin);
            Console.WriteLine("Value of string: {0}", stringVar);
            double double23F = 3.99;
            float float232F = 3.22F;
        }
    }
}