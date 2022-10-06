using System;
using System.Collections.Generic;

namespace ExerciseFour
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter a few words separated by a space (e.g 'number of students') : ");
            string inputWords = Console.ReadLine();
            Console.WriteLine(ConvertPascalCase(inputWords));
        }
        public static string ConvertPascalCase(string sentence)
        {
            List<string> words = new List<string>();
            string newSentence = "";
            if (String.IsNullOrWhiteSpace(sentence))
            {
                return "Error";
            }
            foreach (string substring in sentence.Split(' '))
            {
                words.Add(substring);
            }
            foreach (string word in words)
            {
                newSentence += (word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower());
            }
            return newSentence;

        }
    }
}
