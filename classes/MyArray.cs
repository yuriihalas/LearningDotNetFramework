using System;
using System.Linq;

namespace LearningDotNetFramework
{
    public class MyArray
    {
        public static void RunMyArray()
        {
            //init inline
            string[] names = { "John", "Alex" };
            //init inline with new
            string[] cars = new string[] { "Al", "El", "CV" };

            //add values in new line should be only with new keyword
            //string[] cars2; cars2 = {"VA","AV"}; doesn't compile

            //this is good example
            string[] cars2;
            cars2 = new string[] { "VA", "AV" };

            //Sorting arrays
            int[] digits = { 5, 10, 1, 100, -2 };
            Array.Sort(digits);
            foreach (int digit in digits)
            {
                Console.Write($"{digit} ");
            }

            Console.WriteLine();
            Console.WriteLine(digits.Max());
            Console.WriteLine(digits.Min());
            Console.WriteLine(digits.Sum());

            int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, {2, 4, 4} };
            Console.WriteLine("Output of numbers[0, 2]");
            Console.WriteLine(numbers[0, 2]);

            Console.WriteLine("numbers.GetLength(0) {0}", numbers.GetLength(0));
            Console.WriteLine("numbers.GetLength(1) {0}", numbers.GetLength(1));
            Console.WriteLine("numbers.Length) {0}", numbers.Length);
            
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}