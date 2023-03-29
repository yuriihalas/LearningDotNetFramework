using System;

namespace LearningDotNetFramework
{
    public class MyString
    {
        public static void RunMyString()
        {
            string firstName = "Yurii";
            string lastName = "Halas";
            //String interpolation
            string fullName = $"My full name is: {firstName} + {lastName}";
            string fullName2 = String.Format("My full name is: {0} + {1}", firstName, lastName);
            Console.WriteLine(fullName);
            Console.WriteLine("Length: ");
            Console.WriteLine(fullName.Length);
            Console.WriteLine("To upper case: ");
            Console.WriteLine(fullName.ToUpper());
            Console.WriteLine("First symbol myString[0]: ");
            Console.WriteLine(fullName[0]);
            Console.WriteLine("Index of symbol H, myString.IndexOf('H'): ");
            Console.WriteLine(fullName.IndexOf('H'));
            Console.WriteLine("Substring method, myString.Substring(charPos): ");
            Console.WriteLine(fullName.Substring(fullName.IndexOf('H')));
            Console.WriteLine("Backslash: \"\"");
            Console.WriteLine("Backspace(Delete one space before b): \bF");
        }

        public static void ArgListMethod(__arglist)
        {
            
        }
    }
}