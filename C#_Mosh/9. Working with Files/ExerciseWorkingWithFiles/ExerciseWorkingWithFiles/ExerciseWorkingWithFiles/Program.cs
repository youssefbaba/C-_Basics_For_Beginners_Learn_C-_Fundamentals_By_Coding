using System;
using System.IO;

namespace ExerciseOne
{
    internal class Program
    {
        static void Main()
        {
            //MethodeOne();
            MethodeTwo();
        }
        public static void MethodeOne()
        {
            string path = @"C:\current\Demos\ExerciseOne\test.txt";
            FileInfo fileInfo = new FileInfo(path);
            StreamWriter streamWriter = fileInfo.CreateText();
            streamWriter.WriteLine("Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,");
            streamWriter.WriteLine("numquam blanditiis harum quisquam eius");
            streamWriter.WriteLine("optio, eaque rerum! Provident similique accusantium nemo autem. Veritatis");
            streamWriter.Close();

            StreamReader streamReader = fileInfo.OpenText();
            string newLine = Environment.NewLine;
            string[] separators = new string[] { " ", "\t", newLine };
            string text = streamReader.ReadToEnd().Trim();
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            //foreach (string word in words)
            //{
            //    Console.WriteLine("'{0}'", word);
            //}
            Console.WriteLine("The Number Of Words In File Is : {0} Word ", words.Length);
            streamReader.Close();
        }
        public static void MethodeTwo()
        {
            string path = @"C:\current\Demos\ExerciseOne\test.txt";
            string text = File.ReadAllText(path).Trim();
            string newLine = Environment.NewLine;
            string[] separators = new string[] {" ", "\t", newLine};
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("The Number Of Words In File Is : {0} word",words.Length);
        }
    }
}
