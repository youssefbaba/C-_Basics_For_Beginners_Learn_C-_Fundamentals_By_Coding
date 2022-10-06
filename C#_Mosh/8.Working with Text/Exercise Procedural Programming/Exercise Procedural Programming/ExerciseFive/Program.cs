using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFive
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter an English word : ");
            string inputWord = Console.ReadLine();
            Console.WriteLine(NumberOfVowels(inputWord));
        }
        public static int NumberOfVowels(string word)
        {
            char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i', 'y' };
            int numberVowels = 0;
            foreach (char character in word)
            {
                if (vowels.Contains(character))
                {
                    numberVowels++;
                }
            }
            return numberVowels;
        }
    }
}
