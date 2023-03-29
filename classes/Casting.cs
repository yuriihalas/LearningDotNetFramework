using System;

namespace LearningDotNetFramework
{
    public class Casting
    {
        public static void RunCasting()
        {
            //Implicit casting (automatically) -> converting a smaller type to a larger type size
            //char -> int -> long -> float -> double
            //Explicit casting (manually) -> converting a larger type to a smaller size type
            //double -> float -> long -> int -> char

            //implicit casting
            int myInt = 133;
            double intToDouble = myInt;
            Console.WriteLine("Int to double (double c = int), {0}", intToDouble.ToString());
            
            //explicit casting
            double myDouble = 133.33D;
            int doubleToInt = (int) myDouble;
            Console.WriteLine("Double to int (int c = double), {0}", doubleToInt.ToString());

            //Covert methods
            int myInt2 = 22;
            double myDouble2 = 23.3;
            bool myBool = true;

            int doubleToInt2 = Convert.ToInt32(myDouble2); 
            Console.WriteLine("Double to int with Convert.ToInt32: int c = toInt32 {0}", doubleToInt2.ToString());
        }
    }
}