using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DemoDirectoryDirectoryInfo
{
    internal class Program
    {
        static void Main()
        {
            //DirectoryHandling();
            DirectoryInfoHandling();
        }
        public static void DirectoryHandling()
        {
            string directoryPath = @"C:\current\FolderOne\SubFolderOne";

            // Create  Derectory
            /*
            if (Directory.Exists(directoryPath))
            {
                Console.WriteLine("Directory exists already");
                return;
            }
            try
            {
                DirectoryInfo directory =  Directory.CreateDirectory(directoryPath);
                Console.WriteLine("The directory was created successfully at {0}",Directory.GetCreationTime(directoryPath));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            */


            // Get Files

            /*
            string[] files = Directory.GetFiles(directoryPath);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            */
            /*
            string[] extensions = new string[] {"*.jpg", "*.txt" };
            List<string> files = new List<string>();

            foreach (string extension in extensions)
            {
                List<string> newFiles = Directory.GetFiles(directoryPath, extension).ToList();
                foreach (string file in newFiles)
                {
                    files.Add(file);
                }
            }
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            foreach (string extension in extensions)
            {
                List<string> newFiles = Directory.GetFiles(directoryPath, extension , SearchOption.AllDirectories).ToList();
                foreach (string file in newFiles)
                {
                    files.Add(file);
                }
            }
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            */

            // Get Directories
            /*
            string[] directories = Directory.GetDirectories(directoryPath);
            foreach (string directory in directories)
            {
                Console.WriteLine(directory);
            }
            */

            /*
            //string[] directories = Directory.GetDirectories(directoryPath , "Sub*");
            string[] directories = Directory.GetDirectories(directoryPath , "*Folder*");

            foreach (string directory in directories)
            {
                Console.WriteLine(directory);
            }
            */
            /*
            string[] directories = Directory.GetDirectories(directoryPath, "*.*", SearchOption.AllDirectories);
            foreach (string directory in directories)
            {
                Console.WriteLine(directory);
            }
            */

            // Delete Directory

            /*
            string directoryPathTwo = @"C:\current\FolderOne\NewDirectory\NewSubDirectory";
            Directory.CreateDirectory(directoryPathTwo);
            Directory.Delete(directoryPathTwo);
            bool directoryExists = Directory.Exists(Path.GetDirectoryName(directoryPathTwo));
            bool subDirectoryExists = Directory.Exists(directoryPathTwo);
            Console.WriteLine("top-level directory exists: {0}", directoryExists);
            Console.WriteLine("sub-directory exists: {0}", subDirectoryExists);
            */

            /*
            string topPath = @"C:\current\NewDirectory";
            string subPath = @"C:\current\NewDirectory\NewSubDirectory";
            Directory.CreateDirectory(subPath);
            StreamWriter sw = File.CreateText(Path.Combine(subPath , "example.txt"));
            sw.WriteLine("Some Content Here");
            sw.Close();
            Directory.Delete(topPath, true);
            bool directoryExists = Directory.Exists(topPath);
            Console.WriteLine("top-level directory exists: " + directoryExists);
            */

            // Move Directory

            /*
            // If sourceFilName is a file, then destinationFilName must also be a file name.
            string sourceFilName = @"C:\current\Demos\SubFolderC\test.txt";
            //string destinationFilName = @"C:\current\Demos\SubFolderD\test.txt";
            string destinationFilName = @"C:\current\Demos\SubFolderD\newtest.txt";
            Directory.Move(sourceFilName , destinationFilName);
            */

            /*
            try
            {
                string sourceDirName = @"C:\current\Demos\Source";
                string destinationDirName = @"C:\current\Demos\Destination";
                Directory.Move(sourceDirName, destinationDirName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */

            // Copy Directory

            /*
            try
            {
                // source : C:\current\Demos\CopyDirectory
                string destinationPath = @"C:\current\Demos\Directory\CopyDirectory";
                string sourcePath = @"C:\current\Demos\CopyDirectory";
                Directory.CreateDirectory(destinationPath);
                List<string> files = Directory.GetFiles(sourcePath).ToList();
                List<string> directories = Directory.GetDirectories(sourcePath).ToList();

                foreach (string file in files)
                {
                    File.Copy(file, Path.Combine(destinationPath , Path.GetFileName(file)), true); 
                }
                foreach (string  directory in directories)
                {
                    Directory.CreateDirectory(Path.Combine(destinationPath, Path.GetFileName(directory)));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */

            // Set And Get Creation Time

            // Set the directory.
            string filePath = @"C:\current\Demos\NewDi";
            //Create variable to use to set the time.
            DateTime dtime1 = new DateTime(2002, 1, 3);

            //Create the directory.
            try
            {
                Directory.CreateDirectory(filePath);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            // Print to console the results.
            Console.WriteLine("Creation Date: {0}", Directory.GetCreationTime(filePath));
            Console.WriteLine("UTC creation Date: {0}", Directory.GetCreationTimeUtc(filePath));
            Console.WriteLine("Last write time: {0}", Directory.GetLastWriteTime(filePath));
            Console.WriteLine("UTC last write time: {0}", Directory.GetLastWriteTimeUtc(filePath));
            Console.WriteLine("Last access time: {0}", Directory.GetLastAccessTime(filePath));
            Console.WriteLine("UTC last access time: {0}", Directory.GetLastAccessTimeUtc(filePath));

            //Set the creation and last access times to a variable DateTime value.
            Directory.SetCreationTime(filePath, dtime1);
            Directory.SetLastAccessTimeUtc(filePath, dtime1);
            Console.WriteLine("Creation Date: {0}", Directory.GetCreationTime(filePath));

































            //Directory.GetFiles()
            //Directory.GetFiles()




        }
        public static void DirectoryInfoHandling()
        {
            // Create Directory 
            /*
            string directoryPath = @"C:\current\Demos\Directory";
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
            */

            // Create Subdirectory 
            /*
            try
            {
                string directoryPathTwo = @"C:\current\Demos\NewDirectory";
                string subDirectoryName = @"SubDirectory";
                DirectoryInfo directoryInfoTwo = new DirectoryInfo(directoryPathTwo);
                directoryInfoTwo.Create();
                DirectoryInfo subDirectoryInfo = directoryInfoTwo.CreateSubdirectory(subDirectoryName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */

            // Move Directory 
            /*
            try
            {
                string sourcePath = @"C:\current\Demos\MyDir";
                string destinationPath = @"C:\current\Demos\Public";
                DirectoryInfo df1 = new DirectoryInfo(sourcePath);
                DirectoryInfo df2 = new DirectoryInfo(destinationPath);
                df1.MoveTo(destinationPath);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */

            /*
            try
            {
                string sourcePath = @"C:\current\Demos\MyDir";
                string destinationPath = @"C:\current\Demos\Public\MyDir";
                DirectoryInfo df1 = new DirectoryInfo(sourcePath);
                DirectoryInfo df2 = new DirectoryInfo(destinationPath);
                df1.MoveTo(destinationPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            */
            /*
            try
            {
                string sourcePath = @"C:\current\Demos\NewFolder";
                DirectoryInfo directoryInfoTwo = new DirectoryInfo(sourcePath);
                directoryInfoTwo.Create();
                DirectoryInfo directoryInfoThree = directoryInfoTwo.CreateSubdirectory("NewSubDirectory");
                string destinationPath = @"C:\current\Demos\MoveDirectory";
                directoryInfoTwo.MoveTo(destinationPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */

            // Delete Directory
            /*
            try
            {
                string filePath = @"C:\current\Demos\DeleteDirectory";
                DirectoryInfo directoryInfo = new DirectoryInfo(filePath);
                //directoryInfo.Delete(false);   
                directoryInfo.Delete(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                string filePathTwo = @"C:\current\Demos\NewDeleteDirectory";
                DirectoryInfo directoryInfoTwo = new DirectoryInfo(filePathTwo);
                directoryInfoTwo.Delete();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */


            //Get Files
            /*
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory());
                FileInfo[] files = directoryInfo.GetFiles();
                foreach (FileInfo file in files)
                {
                    Console.WriteLine(file);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */
            /*
            try
            {
                string filePath = @"C:\current\Demos\NewDirectory";
                DirectoryInfo di = new DirectoryInfo(filePath);
                FileInfo[] files =  di.GetFiles();
                Console.WriteLine("No search pattern returns:");
                foreach (FileInfo file in files)
                {
                    Console.WriteLine(file);
                }
                Console.WriteLine("Search pattern *test* returns:");
                FileInfo[] filesOne = di.GetFiles("*test*");
                foreach (FileInfo file in filesOne)
                {
                    Console.WriteLine(file);
                }

                Console.WriteLine("Search pattern AllDirectories returns:");
                FileInfo[] filesThree = di.GetFiles("*.txt" , SearchOption.AllDirectories);
                foreach (FileInfo file in filesThree)
                {
                    Console.WriteLine(file);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */

            // Get Directory

            /*
            try
            {
                string filePath = @"C:\current\Demos\Directory";
                DirectoryInfo dirInfo = new DirectoryInfo(filePath);
                DirectoryInfo[] subDirectories = dirInfo.GetDirectories();
                Console.WriteLine("No search pattern returns:");
                Console.WriteLine("Th Number Of Subdirectories is : {0}" , subDirectories.Length);
                foreach (DirectoryInfo subDirectory in  subDirectories)
                {
                    Console.WriteLine(subDirectory.Name);
                }
                Console.WriteLine("Search pattern Sub* returns:");
                DirectoryInfo[] subDirectoriesTwo = dirInfo.GetDirectories("Sub*");
                Console.WriteLine("Th Number Of Subdirectories is : {0}", subDirectoriesTwo.Length);
                foreach (DirectoryInfo subDirectory in subDirectoriesTwo)
                {
                    Console.WriteLine(subDirectory.Name);
                }
                Console.WriteLine("Search pattern AllDirectories returns:");
                DirectoryInfo[] subDirectoriesThree = dirInfo.GetDirectories("*Folder*" , SearchOption.AllDirectories);
                Console.WriteLine("Th Number Of Subdirectories is : {0}", subDirectoriesThree.Length);
                foreach (DirectoryInfo subDirectory in subDirectoriesThree)
                {
                    Console.WriteLine(subDirectory.Name);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */

            // DirectoryInfo Properties


            string filePath = @"C:\current\Demos\DirectoryUpdate";
            DirectoryInfo di = new DirectoryInfo(filePath);
            string nameDirectory = di.Name;
            Console.WriteLine("Directory Name Is : {0} ", nameDirectory); // Directory


            string creationTime = di.CreationTime.ToString();
            Console.WriteLine("Directory creation time is {0} " , creationTime);


            di.CreationTime = new DateTime(2019, 12, 25, 10, 30, 50);
            Console.WriteLine("Directory New Creation Time {0}" , di.CreationTime);


            string creationTimeUtc = di.CreationTimeUtc.ToString();
            Console.WriteLine("Directory Creation Time Utc Is {0} " , creationTimeUtc);


            bool directoryExist = di.Exists;
            Console.WriteLine("Directory Exist Is {0}" , directoryExist);


            string lastAccessTime = di.LastAccessTime.ToString();
            Console.WriteLine("Directory Last Access Time Is {0} ", lastAccessTime);


            string lastWriteTime = di.LastWriteTime.ToString();
            Console.WriteLine("Directory Last Write Time Is {0} ", lastWriteTime);


            string fullPath = di.FullName;
            Console.WriteLine("Directory Full Name(Full Path) Is {0} ", di.FullName);


            string parentDirectory = di.Parent.ToString();
            Console.WriteLine("Directory Parent Is {0} ", parentDirectory);


            string rootDirectory = di.Root.ToString();
            Console.WriteLine("Root Directory Is {0} ", rootDirectory);
        }
    }
}
