using System;
using System.IO;

namespace LearningDotNetFramework.exceptions
{
    public class MyException
    {

        public static void RunMyException()
        {
            CheckInt(1);
        }


        public static void CheckInt(int limit)
        {
            if (limit < 18)
            {
                throw new FileNotFoundException();
            }
            throw new ArithmeticException("Access denied for higher limit");
        }
    }
}