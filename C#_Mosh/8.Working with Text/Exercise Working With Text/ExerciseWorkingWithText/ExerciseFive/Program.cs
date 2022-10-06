using System;
using System.Linq;

namespace ExerciseFive
{
    class Program
    {
        public void ExerciseFive()
        {
            Console.Write("Please enter an English word : ");
            string inputWord = Console.ReadLine();
            char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i' , 'y'};
            int numberVowels = 0;
            foreach (char character in inputWord)
            {
                if (vowels.Contains(character))
                {
                    numberVowels++;
                }
            }
            Console.WriteLine(numberVowels);
        }
    }
}
