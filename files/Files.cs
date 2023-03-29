using System;
using System.IO;

namespace LearningDotNetFramework.files
{
    public class Files
    {
        public static void RunFiles()
        {
            string textToWrite = "First Line\nSecond Line 2";
            File.WriteAllText("myfile.txt", textToWrite);

            string readText = File.ReadAllText("myfile.txt");
            Console.WriteLine(readText);
        }
    }
}