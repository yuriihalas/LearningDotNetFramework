using System;

namespace LearningDotNetFramework
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Variables.runVars();
        }

        //private static void NewMethod(out string name)
        private static void AskForAge()
        {
            //For run from cmd: dotnet run
            Console.WriteLine("What is you name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}! Have a nice day!", name);
        }
    }
}