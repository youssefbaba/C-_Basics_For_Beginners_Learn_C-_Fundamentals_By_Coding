using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DemoPath
{
    internal class Program
    {
        static void Main()
        {
            PathHandling();
        }
        public static void PathHandling()
        {
            // Get File Name 
            /*
             try
             {
                 //string path = @"C:\current\Demos\NewDirectory";
                 //string path = @"C:\current\Demos\NewDirectory\";
                 string path = @"C:\current\Demos\NewDirectory\log1.txt";
                 string fileName = Path.GetFileName(path);
                 Console.WriteLine("The Result Of GetFileName({0}) Is : '{1}'", path, fileName);
             }
             catch (Exception e)
             {
                 Console.WriteLine(e.Message);
             }
             */


            // Get File Name Without Extension
            /*
            try
            {
                //string path = @"C:\current\Demos\NewDirectory";
                //string path = @"C:\current\Demos\NewDirectory\";
                string path = @"C:\current\Demos\NewDirectory\log1.txt";
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path);
                Console.WriteLine("The Result Of GetFileNameWithoutExtension({0}) Is : '{1}'", path, fileNameWithoutExtension);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */


            // Get Extension
            /*
            try
            {
                //string path = @"C:\current\Demos\NewDirectory";
                //string path = @"C:\current\Demos\NewDirectory\";
                string path = @"C:\current\Demos\NewDirectory\log1.txt";

                string extension = Path.GetExtension(path);
                Console.WriteLine("The Result Of GetExtension({0}) Is : '{1}'", path, extension);

                string path2 = @"C:\current\Demos\NewDirectory\log1.txt.docs";
                string extension2 = Path.GetExtension(path2);
                Console.WriteLine("The Result Of GetExtension({0}) Is : '{1}'", path2, extension2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */

            // Get Root Path
            /*
            try
            {
                string path = @"\mydir\";
                string fileName = "myfile.ext";
                string fullPath = @"C:\mydir\myfile.ext";
                Console.WriteLine("The Result Of GetPathRoot({0}) Is '{1}' ", path ,Path.GetPathRoot(path)); // '\'
                Console.WriteLine("The Result Of GetPathRoot({0}) Is '{1}' ", fileName, Path.GetPathRoot(fileName));  // ''
                Console.WriteLine("The Result Of GetPathRoot({0}) Is '{1}' ", fullPath, Path.GetPathRoot(fullPath)); // 'C:\'

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */


            // Get Directory Name
            /*
            try
            {
                Console.WriteLine("############# Example One ################");
                string pathOne = @"C:\MyDir\MySubDir\myfile.txt";
                string pathTwo = @"C:\MyDir\MySubDir";
                string pathThree = @"C:\MyDir";
                string pathFour = @"C:\";
                string pathFive = @"MyDir";
                Console.WriteLine("{0} Of Type {1}", Path.GetDirectoryName(pathOne), Path.GetDirectoryName(pathOne).GetType());
                Console.WriteLine("{0} Of Type {1}", Path.GetDirectoryName(pathTwo), Path.GetDirectoryName(pathTwo).GetType());
                Console.WriteLine("{0} Of Type {1}", Path.GetDirectoryName(pathThree), Path.GetDirectoryName(pathThree).GetType());
                Console.WriteLine("'{0}' Of Type {1}", Path.GetDirectoryName(pathFive), Path.GetDirectoryName(pathFive).GetType()); // empty string
                Console.WriteLine("{0} Of Type {1}", Path.GetDirectoryName(pathFour), Path.GetDirectoryName(pathFour).GetType()); // null 

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            */

            // Path Syntax
            /*
            try
            {
                string pathOne = @"C:\MyDir\MySubDir\test.txt"; // Verbatim Syntax And This Is A Best Syntax
                string pathTwo = "C:\\MyDir\\MySubDir\\test.txt";
                Console.WriteLine("Verbatim Syntax : {0}" , pathOne);
                Console.WriteLine("Literal Syntax : {0}" , pathTwo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */

            // Get Full Path 
            /*
            try
            {
                string fileName = "myfile.ext";
                string path1 = @"mydir";
                string path2 = @"\mydir";
                string currentDirectory = Directory.GetCurrentDirectory();
                Console.WriteLine(currentDirectory);
                Console.WriteLine(Path.GetFullPath(fileName));
                Console.WriteLine(Path.GetFullPath(path1));
                Console.WriteLine(Path.GetFullPath(path2));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */


            //Combine 
            try
            {
                ////string[] paths = {"Test1" , "Test2", "D:\\archives", "2001", "media", "images" };
                //string[] paths = { "Test1", "Test2", @"D:\archives", "2001", "media", "images" };
                //string filePath = Path.Combine(paths);
                //Console.WriteLine(filePath); //  D:\archives\2001\media\images"

                //string[] paths = { @"D:\archives", "2001", "media", "images" };
                //string fullPath = Path.Combine(paths);
                //Console.WriteLine(fullPath); // D:\archives\2001\media\images"


                // For Window :  \ (1)   AND  / (2)
                //string[] paths = new string[] { @"D:\archives\", @"2001\", "media", "images" };
                //string fullPath = Path.Combine(paths);
                //Console.WriteLine(fullPath); // D:\archives\2001\media\images"


                // For Mac  : / (1)
                //string[] paths = new string[] { @"D:\archives\", @"2001\", "media", "images" };
                //string fullPath = Path.Combine(paths);
                //Console.WriteLine(fullPath); // D:\archives\/2001\/media/images"


                // For Window :  \ (1)   AND  / (2)
                //string[] paths = new string[] { "D:/archives/", "2001/", "media", "images" };
                //string fullPath = Path.Combine(paths);
                //Console.WriteLine(fullPath); // D:/archives/2001/media\images"

                // For Mac  : / (1)
                //string[] paths = new string[] { "D:/archives/", "2001/", "media", "images" };
                //string fullPath = Path.Combine(paths);
                //Console.WriteLine(fullPath); // D:/archives/2001/media/images"
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //string path1 = "c:\\temp";
            //string path2 = "subdir\\file.txt";
            //string path3 = "c:\\temp.txt";
            //string path4 = "c:^*&)(_=@#'\\^&#2.*(.txt";
            //string path5 = "";
            //string path6 = null;

            //CombinePaths(path1, path2);
            // When you combine 'c:\temp' and 'subdir\file.txt', the result is:
            // 'c:\temp\subdir\file.txt'


            //CombinePaths(path1, path3);
            // When you combine 'c:\temp' and 'c:\temp.txt', the result is:
            // 'c:\temp.txt'


            //CombinePaths(path3, path2);
            // When you combine 'c:\temp.txt' and 'subdir\file.txt', the result is:
            // 'c:\temp.txt\subdir\file.txt'


            //CombinePaths(path4, path2);
            // When you combine 'c:^*&)(_=@#'\^&#2.*(.txt' and 'subdir\file.txt', the result is:
            // 'c:^*&)(_=@#'\^&#2.*(.txt\subdir\file.txt'


            //CombinePaths(path5, path2);
            // When you combine '' and 'subdir\\file.txt', the result is:
            // 'subdir\file.txt'

            //CombinePaths(path6, path2);
            // You cannot combine '' and 'subdir\\file.txt' because 
            // path6 is null





        }
        public static void CombinePaths(string pathOne , string pathTwo)
        {
            try
            {
                string combination = Path.Combine(pathOne, pathTwo);
                Console.WriteLine("When you combine '{0}' and '{1}', the result is: {2}'{3}'",
                            pathOne, pathTwo, Environment.NewLine, combination);
            }
            catch (Exception e)
            {
                if (pathOne == null)
                {
                    pathOne = "null";
                }
                if (pathTwo == null)
                {
                    pathTwo = "null";
                }
                Console.WriteLine("You cannot combine '{0}' and '{1}' because: {2}{3}",
                        pathOne, pathTwo, Environment.NewLine, e.Message);
            }

        }
       
    }
}
