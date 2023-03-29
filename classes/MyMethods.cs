using System;
using System.Runtime.InteropServices;
using System.Xml;

namespace LearningDotNetFramework
{
    public class MyMethods
    {
        public static void RunMyMethods()
        {
            //without parameters run method
            MyMethod();
            MyMethod("Sss");
            MyMethod(s2: "s2", s1: "s1");
            MyMethod(s2: "s2", s3: "ss33", s1: "s1");
            
            Plus(1, 11);
            Plus(Convert.ToUInt32(1), Convert.ToUInt32(11));
        }

        internal static void MyMethod(string count = "Ukraine")
        {
            Console.WriteLine(count);
        }

        public static void MyMethod()
        {
            Console.WriteLine("Without parameters");
        }

        //optional parameters must appear after all required (below error)
        //public static void MyMethod(string f = "2", string s = "3", string t)
        public static void MyMethod(string s1, string s2, string s3 = "s3")
        {
            Console.WriteLine("s1: {0}", s1);
            Console.WriteLine("s2: {0}", s2);
            Console.WriteLine("s3: {0}", s3);
        }

        public static void Plus(int x, int y)
        {
            Console.WriteLine("int, int");
            Console.WriteLine(x + y);
        }

        public static void Plus(uint x, uint y)
        {
            Console.WriteLine("uint, uint");
            Console.WriteLine(x + y);
        }
    }
}