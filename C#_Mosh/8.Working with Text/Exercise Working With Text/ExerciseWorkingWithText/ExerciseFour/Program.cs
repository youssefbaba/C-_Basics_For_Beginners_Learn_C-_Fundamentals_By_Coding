using System;
using System.Collections.Generic;

namespace ExerciseFour
{
    class Program
    {
        public void ExerciseFour()
        {
           Console.Write("Please enter a few words separated by a space (e.g 'number of students') : ");
           string input = Console.ReadLine();
           List<string> words = new List<string>();
           string newWords = "";
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }
            foreach (string substring in input.Split(' '))
            {
                words.Add(substring);
            }
            foreach (string word in words)
            {
                newWords += (word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower());
            }
            Console.WriteLine(newWords);
           
        }
    }
}
