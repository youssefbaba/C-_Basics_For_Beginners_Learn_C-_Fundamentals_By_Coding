using System;
using System.IO;

namespace ExerciseTwo
{
    internal class Program
    {
        static void Main()
        {
            string path = @"C:\current\Demos\ExerciseOne\test.txt";
            string content = File.ReadAllText(path).Trim();
            string newLine = Environment.NewLine;
            string[] separators = new string[] {" ","\t",newLine};
            string[] words = content.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int max = 0;
            foreach (string word in words)
            {
                if (word.Length >= max)
                {
                    max = word.Length;
                }
            }
            foreach (string word in words)
            {
                if (word.Length == max)
                {
                    Console.WriteLine("The Longest Word Is '{0}' That Contain {1} Character ." , word ,max) ;
                    break;
                }
            }
        }
    }
}
