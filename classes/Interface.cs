using System;

namespace LearningDotNetFramework.classes
{
    //by default members of an interface are abstract and public
    //and properties are allowed
    public interface IStone
    {
        //can contain properties also
        public abstract string Name { get; set; }

        public abstract void ShowName();
        
    }

    public class GemStone : IStone
    {
        //but properties should be implemented
        public string Name { get; set;}
        public void ShowName()
        {
            Console.WriteLine(Name);
        }

        public static void Run()
        {
            IStone stone = new GemStone();
            stone.Name = "Diamond";
            stone.ShowName();
        }
    }
}