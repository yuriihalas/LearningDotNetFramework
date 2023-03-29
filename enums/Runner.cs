using System;

namespace LearningDotNetFramework.enums
{
    public class Runner
    {
        public enum Level
        {
            Min,
            Max
        }
        
        public static void RunEnums()
        {
            var month = Months.July | Months.January;
            if ((month & Months.July) != 0)
            {
                Console.WriteLine(month);
            }
            if ((month & Months.January) != 0)
            {
                Console.WriteLine(month);
            }

            var jan = Months.January;

            if (jan.Equals(Months.January))
            {
                Console.WriteLine("Jan");
            }
        }
    }
}