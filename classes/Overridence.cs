using System;

namespace LearningDotNetFramework.classes
{
    public class Animal
    {
        //without virtual you cannot override correctly this method
        //and all three calls in Run will be as Animal Sound
        public virtual void Sound()
        {
            Console.WriteLine("Animal Sound");
        }
    }

    public class Pig : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Pig Sound");
        }
    }

    public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog Sound");
        }
        
        
        public static void Run()
        {
            Animal animal = new Animal();
            Animal pig = new Pig();
            Animal dog = new Dog();

            animal.Sound();
            pig.Sound();
            dog.Sound();
        }
    }
}