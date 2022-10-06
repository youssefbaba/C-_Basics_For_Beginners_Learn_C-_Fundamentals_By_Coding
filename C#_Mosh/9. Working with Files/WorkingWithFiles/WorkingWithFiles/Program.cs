using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DemoFileAndFileInfo
{
    internal class Program
    {
        static void Main()
        {
            //CreateFile();
            //CopyFile();
            //MoveFile();
            //FileHandling();
            FileInfoHandling();
        }
        public static void CreateFile()
        {
            string sourcePath = @"C:\current\createfile.txt";
            using (FileStream fileStream = File.Create(sourcePath)) { }
        }
        public static void CopyFile()
        {
            string sourcePath = @"C:\current";
            string destinationPath = @"C:\archives\2008";
            List<string> files = new List<string>();
            string[] extensions = new string[] {"text*.txt" ,"*.jpg", };

            foreach (string extension in extensions)
            {
                List<string> newFiles = Directory.GetFiles(sourcePath, extension).ToList();
                foreach (string file in newFiles)
                    files.Add(file);
            }


            // Test Existent File
            foreach (string file in files)
            {
                if (File.Exists(Path.Combine(destinationPath, Path.GetFileName(file))))
                {
                    Console.WriteLine("The File : {0} already exist In {1}", Path.GetFileName(file), Path.Combine(destinationPath, Path.GetFileName(file)));
                }
            }


            // Copy File
            foreach (string file in files)
            {
                //File.Copy(file, $"{destinationPath}\\{Path.GetFileName(file)}"); 
                //File.Copy(file, Path.Combine(destinationPath, Path.GetFileName(file)));
                File.Copy(file, Path.Combine(destinationPath, Path.GetFileName(file)), true);
                //Console.WriteLine(file);
            }


            // Delete File
            foreach (string file in files)
            {
                if (File.Exists(file))
                {
                    File.Delete(file); 
                }
            }
        }
        public static void MoveFile()
        {
            string sourcePath = @"C:\current\testMove.txt";
            //string destinationPath = @"C:\archives\2008\testMove.txt"; // Move File From sourcePath To destinationPath
            string destinationPath = @"C:\archives\2008\newtestMove.txt";  // Rename And Move File From sourcePath To destinationPath
            if (!File.Exists(sourcePath))
            {
                using (FileStream fileStream = File.Create(sourcePath)){}
            }
            if (File.Exists(destinationPath))
            {
                File.Delete(destinationPath);
            }

            // Move the file.
            File.Move(sourcePath, destinationPath);
            Console.WriteLine("{0} was moved to {1}.", sourcePath , destinationPath);

            // Test If The Original File Exist Or Not 
            if (File.Exists(sourcePath))
            {
                Console.WriteLine("The original file still exists, which is unexpected.");
            }
            else
            {
                Console.WriteLine("The original file no longer exists, which is expected.");
            }
        }
        public static void FileHandling()
        {

            // Create 
            // Copy
            // Delete 
            // Exists
            // WriteAllText
            // ReadAllText
            // Move 


            string filePath = @"C:\current\test.txt";
            File.Create(filePath);
            if (File.Exists(filePath))
            {
                Console.WriteLine("File Created Succefully");
            }
            else
            {
                Console.WriteLine("Unable To Create File");
            }

            // Write/Read Text
            string filePathOne = @"C:\current\test1.txt";
            if (!File.Exists(filePathOne))
            {
                // Create File To Write to
                string content = "Hello Youssef Baba , How Are You ?";
                File.WriteAllText(filePathOne, content);
            }
            else
            {
                Console.WriteLine("File Already Exist ");
            }
            // Read From File
            string textRead = File.ReadAllText(filePathOne);
            Console.WriteLine(textRead);


            // Write/Read  (array string)
            string filePathTwo = @"C:\current\test2.txt";
            if (!File.Exists(filePathTwo))
            {
                string[] contents = new string[]
                {
                "Line 1",
                "Line 2",
                "Line 3",
                "Line 4"
                };
                File.WriteAllLines(filePathTwo, contents);
            }
            else
            {
                Console.WriteLine("File Not Found .");
            }
            //Read From File
            string[] lines = File.ReadAllLines(filePathTwo);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }


            // Write/Read (List string)
            string filePathThree = @"C:\current\test3.txt";
            if (!File.Exists(filePathThree))
            {
                List<string> contents = new List<string>
                {
                    "Hi",
                    "How",
                    "Are",
                    "You"
                };
                File.WriteAllLines(filePathThree, contents);

            }
            else
            {
                Console.WriteLine("File Not Found");
            }
            List<string> linesTwo = File.ReadLines(filePathThree).ToList();
            foreach (string line in linesTwo)
            {
                Console.WriteLine(line);
            }
        }
        public static void FileInfoHandling()
        {

            // Create
            // Exists
            // NameDirectory
            // Extension
            // FullName
            // Length
            // FileName
            // Last Access
            // Creation Time


            string filePath = @"C:\current\Demos\Directory\fileInfo.txt";
            FileInfo fileInfo = new FileInfo(filePath);

            if (!fileInfo.Exists)
            {
                fileInfo.Create();
            }
            string fullPath = fileInfo.DirectoryName;
            Console.WriteLine("Full Directory Name is : {0}", fullPath);

            string extension = fileInfo.Extension;
            Console.WriteLine("Extension of File is : {0}", extension);

            string fullName = fileInfo.FullName;
            Console.WriteLine("Fulll Name (Full Path) is : {0}", fullName);

            int length = Convert.ToInt32(fileInfo.Length);
            Console.WriteLine("The Size Of File Is : {0}", length);

            string fileName = fileInfo.Name;
            Console.WriteLine("File Name is : {0}", fileName);

            string creationTime = fileInfo.CreationTime.ToString();
            Console.WriteLine("Creation Time : {0}" , creationTime);

            string lastAccessTime = fileInfo.LastAccessTime.ToString();
            Console.WriteLine("Last Access Time Is : {0}" , lastAccessTime) ;


            // Copy
            // Delete
            // Read 
            // Write
            // Read
            // Move
            // Create Text
            // Create 


            // Create Method
            /*
            string filePathOne = @"C:\current\Demos\Directory\fileInfoOne.txt";
            FileInfo fi = new FileInfo(filePathOne);
            FileStream fs = fi.Create();
            if (fi.Exists)
            {
                Console.WriteLine("File Has Been Created");
            }
            */


            // CreateText Method 
            /*
            string filePathTwo = @"C:\current\Demos\Directory\fileInfoTwo.txt";
            FileInfo fi = new FileInfo(filePathTwo);
            if (!fi.Exists)
            {
                StreamWriter sw = fi.CreateText();
                sw.WriteLine("Hello");
                sw.WriteLine("Youssef");
                sw.WriteLine("Baba");
                sw.Close();
                Console.WriteLine("File has been created");
            }
            StreamReader sr = fi.OpenText();
            string text = "";
            while ((text = sr.ReadLine()) != null)
            {
                Console.WriteLine(text);
            }
            */


            // Delete The File
            /*
            string filePathThree = @"C:\current\Demos\Directory\fileInfoThree.txt";
            FileInfo fileInfoThree = new FileInfo(filePathThree);
            if (!fileInfoThree.Exists)
            {
                FileStream fileStream = fileInfoThree.Create();
            }
            fileInfoThree.Delete();
            Console.WriteLine("File has been deleted");
            */

            // Copy Method 
            /*
            string sourcePath = @"C:\current\Demos\Directory\fileInfoFour.txt";
            string destinationpath = @"C:\current\Demos\Directory\SubDirectory\fileInfoFour.txt";
            FileInfo fileInfoFour = new FileInfo(sourcePath);
            FileInfo fileInfoFive = new FileInfo(destinationpath);  
            if (fileInfoFive.Exists)
            {
                fileInfoFive.Delete();
            }
            //fileInfoFour.CopyTo(destinationpath);
            fileInfoFour.CopyTo(destinationpath, true); // allow an existing file to be overwritten
            Console.WriteLine("{0} was copied to {1}" , fileInfoFour , fileInfoFive.);

            // Delete Original From Source 

            if (fileInfoFour.Exists)
            {
                fileInfoFour.Delete();
            }
            */

            // Move Method
            /*
            string sourcePathTwo = @"C:\current\Demos\Directory\fileInfoFive.txt";
            string destinationPathTwo = @"C:\current\Demos\Directory\SubDirectory\newfileInfoFive.txt";
            FileInfo fileInfoTwo = new FileInfo(sourcePathTwo);
            if (!fileInfoTwo.Exists)
            {
                FileStream fileStreamTwo = fileInfoTwo.Create();
                Console.WriteLine("File has been created");
            }
            fileInfoTwo.MoveTo(destinationPathTwo); // Just move file from  sourcePathTwo to destinationPathTwo 
            if (File.Exists(destinationPathTwo))
            {
                Console.WriteLine("File has been moved");
            }
            */

            // Open Text Method
            /*
            string filePathFour = @"C:\current\Demos\Directory\write-read.txt";
            FileInfo fileInfoFour = new FileInfo(filePathFour); 

            StreamWriter streamwriter = fileInfoFour.CreateText();
            streamwriter.WriteLine("Hello");
            streamwriter.WriteLine("Omar");
            streamwriter.WriteLine("How Are You ?");
            streamwriter.Close();

            StreamReader streamReader = fileInfoFour.OpenText();
            //Console.WriteLine(streamReader.ReadToEnd());

            string text = "";
            while ((text = streamReader.ReadLine()) != null)
            {
                Console.WriteLine(text);
            }
            streamReader.Close();
            */
        }

    }
}



