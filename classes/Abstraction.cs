using System;

namespace LearningDotNetFramework.classes
{
    public abstract class Abstraction
    {
        public abstract void GetName();
    }

    public class Child : Abstraction
    {
        public override void GetName()
        {
            Console.WriteLine("Child GetName");
        }

        public static void Run()
        {
            Abstraction abstraction = new Child();
            abstraction.GetName();
        }
    }
}