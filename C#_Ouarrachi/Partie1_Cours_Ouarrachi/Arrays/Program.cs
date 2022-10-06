namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - link 1 :  https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/
             - link 2 : https://www.decodejava.com/csharp-array.htm
             - link 3 : https://stackoverflow.com/questions/1113819/arrays-heap-and-stack-and-value-types#:~:text=Your%20array%20is%20allocated%20on,are%20allocated%20on%20the%20stack.
             - link 4 : https://dotnettutorials.net/lesson/arrays-csharp/ 

             */

            // Declaration of array : 
            int[] t1 = { 1, 2, 3 };
            int[] t2 = new int[3];
            int[] t3 = new int[] { 1, 2, 3, 4 };
            int[] t4 = new int[4] { 1, 2, 3, 4 };

            // Display Elements of array :
            for (int i = 0; i < t4.Length; i++)
            {
                Console.WriteLine($"Element[{i}] = {t4[i]}");
            }
            /*
            Element[0] = 1
            Element[1] = 2
            Element[2] = 3
            Element[3] = 4
             */


            // Declaration of one dimensional array is :  type[] name-array  - example : int[] array ;
            // arrays are reference type 
            // Declaration and constructing of one  dimensionel array is : type[] name-array = new type[size]   - example int[] array = new int[4];


            Console.WriteLine("####### uninitialized int array #######");
            int[] arrayOne = new int[4];
            foreach (int item in arrayOne)
            {
                Console.WriteLine(item);
            }
            /*
            0
            0
            0
            0
             */

            Console.WriteLine("####### uninitialized string array #######");
            string[] arrayTwo = new string[3];
            foreach (string item in arrayTwo)
            {
                Console.WriteLine($"'{item}'");
            }
            /*
            ''
            ''
            ''
             */

            Console.WriteLine("####### uninitialized bool array #######");
            bool[] arrayThree = new bool[4];
            foreach (bool item in arrayThree)
            {
                Console.WriteLine(item);
            }
            /*
            False
            False
            False
            False
             */
            Console.WriteLine("####### Construction and Initialization of one dimension array #######");
            Console.WriteLine("####### method 1 #######");
            int[] arrayInteger = new int[4] { 12, 13, 14, 15 };
            foreach (int item in arrayInteger)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("####### method 2 #######");
            bool[] arrayBoolean = new bool[] { true, false, true, false };
            foreach (bool item in arrayBoolean)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("####### method 3 #######");
            string[] arrayString = { "youssef", "hassna", "omar", "hamza" };
            foreach (string item in arrayString)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("####### method 4 #######");
            char[] arrayChar = new char[4];
            // storing c at index 0 in array
            arrayChar[0] = 'c';
            // storing a at index 1 in array
            arrayChar[1] = 'a';
            // storing d at index 2 in array
            arrayChar[2] = 'd';
            // storing i at index 3 in array
            arrayChar[3] = 'i';

            foreach (char item in arrayChar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("####### Read the elements of an array #######");

            char[] arrayCharacters = new char[4];
            arrayCharacters[0] = 'a';
            arrayCharacters[1] = 'b';
            arrayCharacters[2] = 'c';
            arrayCharacters[3] = 'd';
            for (int i = 0; i < arrayCharacters.Length; i++)
            {
                Console.WriteLine(arrayCharacters[i]);
            }


            Console.WriteLine("####### holding object references #######");

            //Creating 4 object of type Test
            Test test1 = new Test();
            Test test2 = new Test();
            Test test3 = new Test();
            Test test4 = new Test();
            //Array holding 4 object references of type, Test.
            Test[] arrayObjects = new Test[4] { test1, test2, test3, test4 };
            for (int i = 0; i < arrayObjects.Length; i++)
            {
                Console.WriteLine(arrayObjects[i]);
            }

            //Array holding 3 object references of type, Quiz.
            Quiz[] arrayObjectsTwo = new Quiz[3];

            //Creating 3 objects of type Quiz
            Quiz quiz1 = new Quiz();
            Quiz quiz2 = new Quiz();
            Quiz quiz3 = new Quiz();

            //Assigning reference of the first object to the first array element with index position 0
            arrayObjectsTwo[0] = quiz1;
            //Assigning reference of the second object to the second array element with index position 1
            arrayObjectsTwo[1] = quiz2;
            //Assigning reference of the third object to the third array element with index position 2
            arrayObjectsTwo[2] = quiz3;
            for (int i = 0; i < arrayObjectsTwo.Length; i++)
            {
                Console.WriteLine(arrayObjectsTwo[1]);
            }

            Console.WriteLine("##### An array holding object references will be automatically initialized to null ##");
            Test[] arrayObjectsThree = new Test[4];
            for (int i = 0; i < arrayObjectsThree.Length; i++)
            {
                if (arrayObjectsThree[i] == null)
                {
                    Console.WriteLine($"Element[{i}] is null");
                }
                else
                {
                    Console.WriteLine($"Element[{i}] isn't null");
                }
            }


            Console.WriteLine("####### Two dimensional array #######");
            int[,] arrayFive = new int[3, 4];
            Console.WriteLine($"{arrayFive.Length} elements");
            Console.WriteLine("Before");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{arrayFive[i, j]}  ");
                }
                Console.WriteLine();
            }

            arrayFive[0, 0] = 1;
            arrayFive[0, 1] = 2;
            arrayFive[0, 2] = 3;
            arrayFive[0, 3] = 4;
            arrayFive[1, 0] = 5;
            arrayFive[1, 1] = 6;
            arrayFive[1, 2] = 7;
            arrayFive[1, 3] = 8;
            arrayFive[2, 0] = 9;
            arrayFive[2, 1] = 10;
            arrayFive[2, 2] = 11;
            arrayFive[2, 3] = 12;

            Console.WriteLine("After");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{arrayFive[i, j]}  ");
                }
                Console.WriteLine();
            }

            // Declaration of 2D array : type[ , ] name_array;
            // Declaration of a 2D array, which will hold arrays of int values.
            int[,] arrayTwoDInt;
            //Declaring a 2D array holding arrays of object references of the type class Test
            Test[,] arrayTwoDObjects;

            // Construction of 2D array: type[ , ] name_array = new type[first-dimension , second-dimension];

            double[,] arrayDouble1 = new double[3, 3];
            foreach (int item in arrayDouble1)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();

            int[,] arrayInt1 = new int[3, 3];
            foreach (int item in arrayInt1)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();

            bool[,] arrayBool1 = new bool[3, 3];
            foreach (bool item in arrayBool1)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();

            string[,] arrayString1 = new string[3, 3];
            foreach (string item in arrayString1)
            {
                if (item == null)
                {
                    Console.Write("null  ");
                }
                else
                {
                    Console.Write($"{item}  ");
                }
            }
            Console.WriteLine();


            // Creation and Construction of 2D array holding 3 int arrays(each array holding 3 int values).
            int[,] arraySix = new int[3, 3];

            // Initialization of 2D array
            arraySix[0, 0] = 10; //inserting 10 in the first(0 index) array at its 0 index  
            arraySix[0, 1] = 20; //inserting 20 in the first(0 index) array at its 1 index 
            arraySix[0, 2] = 30; //inserting 30 in the first(0 index) array at its 2 index

            arraySix[1, 0] = 40; //inserting 40 in the second(1 index) array at its 0 index
            arraySix[1, 1] = 50; //inserting 50 in the second(1 index) array at its 1 index
            arraySix[1, 2] = 60; //inserting 60 in the second(1 index) array at its 2 index

            arraySix[2, 0] = 70; //inserting 70 in the third(2 index) array at its 0 index
            arraySix[2, 1] = 80; //inserting 50 in the third(2 index) array at its 1 index
            arraySix[2, 2] = 90; //inserting 60 in the third(2 index) array at its 2 index

            //Checking the total numbers of elements in our 2D array by using the Length property of array
            Console.WriteLine($"Length of our 2D array is : {arraySix.Length}");
            Console.WriteLine("Contents of this array are : ");

            // Display the elements of 2D array
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{arraySix[i, j]} ");
                }
                Console.WriteLine();
            }


            // Creation and Construction and Initialization at same time of 2D string array
            string[,] arrayNames = new string[2, 3] { { "toto", "bob", "lolo" }, { "fofo", "koko", "momo" } };
            // to read and display an element at the 0 index of 2nd array in our 2D string array
            Console.WriteLine(arrayNames[1, 0]); // fofo


            // 2D array holding object references
            // first Creation and Construction of Object Refrences 2D array
            Test[,] arrayTest = new Test[2, 3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (arrayTest[i, j] == null)
                    {
                        Console.Write("null  ");
                    }
                    else
                    {
                        Console.WriteLine($"{arrayTest[i, j]}");
                    }
                }
                Console.WriteLine();
            }

            // Creation the objects of type Test
            Test test10 = new Test();
            Test test11 = new Test();
            Test test12 = new Test();
            Test test13 = new Test();
            Test test14 = new Test();
            Test test15 = new Test();

            // Initialization of Object Refrences 2D array
            arrayTest[0, 0] = test10; //inserting an object of Test in the first(0 index) array at its 0 index.
            arrayTest[0, 1] = test11; //inserting an object of Test in the first(0 index) array at its 1 index.
            arrayTest[0, 2] = test12; //inserting an object of Test in the first(0 index) array at its 2 index.

            arrayTest[1, 0] = test13; //inserting an object of Test in the second(1 index) array at its 0 index.
            arrayTest[1, 1] = test14; //inserting an object of Test in the second(1 index) array at its 1 index.
            arrayTest[1, 2] = test15; //inserting an object of Test in the second(1 index) array at its 2 index.

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{arrayTest[i, j]} ");
                }
                Console.WriteLine();
            }



            Quiz quiz10 = new Quiz();
            Quiz quiz20 = new Quiz();
            Quiz quiz30 = new Quiz();

            Quiz quiz40 = new Quiz();
            Quiz quiz50 = new Quiz();
            Quiz quiz60 = new Quiz();

            Quiz quiz70 = new Quiz();
            Quiz quiz80 = new Quiz();
            Quiz quiz90 = new Quiz();

            // Creation and Construction and Initialization of Object refrences 2D array
            Quiz[,] arrayQuiz = new Quiz[3, 3] { { quiz10, quiz20, quiz30 }, { quiz40, quiz50, quiz60 }, { quiz70, quiz80, quiz90 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{arrayQuiz[i, j]}  ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("###### jagged array ######");
            int[][] jaggedArrayOne = new int[3][];
            jaggedArrayOne[0] = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{jaggedArrayOne[0][i]} ");
            }
            Console.WriteLine();
            jaggedArrayOne[0][0] = 10;
            jaggedArrayOne[0][1] = 20;
            jaggedArrayOne[0][2] = 30;
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{jaggedArrayOne[0][i]} ");
            }
            Console.WriteLine();
            jaggedArrayOne[1] = new int[2];
            for (int i = 0; i < 2; i++)
            {
                Console.Write($"{jaggedArrayOne[1][i]} ");
            }
            Console.WriteLine();
            jaggedArrayOne[1][0] = 40;
            jaggedArrayOne[1][1] = 50;
            for (int i = 0; i < 2; i++)
            {
                Console.Write($"{jaggedArrayOne[1][i]} ");
            }
            Console.WriteLine();
            jaggedArrayOne[2] = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{jaggedArrayOne[2][i]} ");
            }
            Console.WriteLine();
            jaggedArrayOne[2][0] = 60;
            jaggedArrayOne[2][1] = 70;
            jaggedArrayOne[2][2] = 80;
            jaggedArrayOne[2][3] = 90;
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{jaggedArrayOne[2][i]} ");
            }
            Console.WriteLine();

            // Declaration of 2D jagged array : type[][] name_array;
            // Declaration of a 2D jagged array, which will hold multiple 1D arrays of int values.
            int[][] jaggedArrayInt;

            // Declaration of 2D jagged array holding 1D arrays of object references of the type class Test.
            Test[][] jaggedArrayObject;


            // Construction of 2D jagged array : type[][] name_array = new type[first dimension][]
            //A 2D jagged Array is constructed on the heap with a size to hold 3 1D int arrays.
            //Where, we are still to define the total number of elements in each of these 1D arrays.
            int[][] jaggedArrayTwo = new int[3][];
            //First 1D array will have 4 int values
            jaggedArrayTwo[0] = new int[4];
            //Second 1D array will have 2 int values
            jaggedArrayTwo[1] = new int[2];
            //Third 1D array will have 3 int values
            jaggedArrayTwo[2] = new int[3];
            //Prints the total number of 1D array contains in this 2D jagged array
            Console.WriteLine($"the total number of 1D array in a 2D jagged array : {jaggedArrayTwo.Length}");
            //Reading the elements of the first 1D array
            Console.Write("the elements of the first 1D array by using foreach loop : ");
            foreach (int item in jaggedArrayTwo[0])
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.Write("the elements of the first 1D array by using for loop : ");
            for (int i = 0; i < jaggedArrayTwo[0].Length; i++)
            {
                Console.Write($"{jaggedArrayTwo[0][i]} ");
            }
            //Reading the elements of the Second 1D array
            Console.WriteLine();
            Console.Write("the elements of the second 1D array by using foreach loop : ");
            foreach (int item in jaggedArrayTwo[1])
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.Write("the elements of the second 1D array by using for loop : ");
            for (int i = 0; i < jaggedArrayTwo[1].Length; i++)
            {
                Console.Write($"{jaggedArrayTwo[1][i]} ");
            }

            //Reading the elements of the Third 1D array
            Console.WriteLine();
            Console.Write("the elements of the Third 1D array by using foreach loop : ");
            foreach (int item in jaggedArrayTwo[2])
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.Write("the elements of the Third 1D array by using for loop : ");
            for (int i = 0; i < jaggedArrayTwo[2].Length; i++)
            {
                Console.Write($"{jaggedArrayTwo[2][i]} ");
            }
            Console.WriteLine();


            // Initialization and reading of 2D jagged array
            //A 2D jagged Array is constructed on the heap with a size to hold 3 1D int arrays.
            //Where, we are still to define the total number of elements in each of these 1D arrays.
            int[][] jaggedArrayThree = new int[3][];
            //First 1D array will have 5 int values
            jaggedArrayThree[0] = new int[5];
            //First 1D array will have 2 int values
            jaggedArrayThree[1] = new int[2];
            //First 1D array will have 4 int values
            jaggedArrayThree[2] = new int[4];
            //Prints the total number of 1D array contains in this 2D jagged array
            Console.WriteLine($"the total number of 1D array in 2D jagged : {jaggedArrayThree.Length}");
            //Initializing the elements of the first 1D array
            for (int i = 0; i < jaggedArrayThree[0].Length; i++)
            {
                jaggedArrayThree[0][i] = i + 10;
            }
            //Initializing the elements of the second 1D array
            for (int i = 0; i < jaggedArrayThree[1].Length; i++)
            {
                jaggedArrayThree[1][i] = i + 20;
            }
            //Initializing the elements of the third 1D array
            for (int i = 0; i < jaggedArrayThree[2].Length; i++)
            {
                jaggedArrayThree[2][i] = i + 30;
            }
            //Reading the elements of the first 1D array
            Console.Write("the elements of the first 1D array bu using foreach loop : ");
            foreach (int item in jaggedArrayThree[0])
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.Write("the elements of the first 1D array bu using for loop : ");
            for (int i = 0; i < jaggedArrayThree[0].Length; i++)
            {
                Console.Write($"{jaggedArrayThree[0][i]} ");
            }
            Console.WriteLine();
            //Reading the elements of the second 1D array
            Console.Write("the elements of the second 1D array bu using foreach loop : ");
            foreach (int item in jaggedArrayThree[1])
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.Write("the elements of the second 1D array bu using for loop : ");
            for (int i = 0; i < jaggedArrayThree[1].Length; i++)
            {
                Console.Write($"{jaggedArrayThree[1][i]} ");
            }
            Console.WriteLine();
            //Reading the elements of the third 1D array
            Console.Write("the elements of the third 1D array bu using foreach loop : ");
            foreach (int item in jaggedArrayThree[2])
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.Write("the elements of the third 1D array bu using for loop : ");
            for (int i = 0; i < jaggedArrayThree[2].Length; i++)
            {
                Console.Write($"{jaggedArrayThree[2][i]} ");
            }
            Console.WriteLine();

            // 2D Jagged array holding 1D arrays of object references

            //A 2D jagged Array is constructed on the heap with a size to hold 3 1D arrays to hold object references of Test.
            //But, we are still to define the total number of object references/elements in each of these 1D arrays.
            Test[][] jaggedArrayTest = new Test[2][];
            //First 1D array will have 3 object references of Test
            jaggedArrayTest[0] = new Test[3];
            //Second 1D array will have 2 object references of Test
            jaggedArrayTest[1] = new Test[2];
            //Reading the elements of the first 1D array
            Console.Write($"the elements of the first 1D array before initilization : ");
            for (int i = 0; i < jaggedArrayTest[0].Length; i++)
            {
                if (jaggedArrayTest[0][i] == null)
                {
                    Console.Write($"null ");
                }
                else
                {
                    Console.Write($"{jaggedArrayTest[0][i]} ");
                }
            }
            Console.WriteLine();
            //Reading the elements of the first 1D array
            Console.Write($"the elements of the second 1D array before initilization : ");
            for (int i = 0; i < jaggedArrayTest[1].Length; i++)
            {
                if (jaggedArrayTest[1][i] == null)
                {
                    Console.Write($"null ");
                }
                else
                {
                    Console.WriteLine($"{jaggedArrayTest[1][i]} ");
                }
            }

            //Initializing the elements of the first 1D array
            jaggedArrayTest[0][0] = test1;
            jaggedArrayTest[0][1] = test2;
            jaggedArrayTest[0][2] = test3;

            //Initializing the elements of the second 1D array
            jaggedArrayTest[1][0] = test10;
            jaggedArrayTest[1][1] = test11;

            //Reading the elements of the first 1D array
            Console.WriteLine();
            Console.Write($"the elements of the first 1D array after initilization : ");
            for (int i = 0; i < jaggedArrayTest[0].Length; i++)
            {

                if (jaggedArrayTest[0][i] == null)
                {
                    Console.Write($"null ");
                }
                else
                {
                    Console.Write($"{jaggedArrayTest[0][i]} ");
                }
            }
            //Reading the elements of the second 1D array
            Console.WriteLine();
            Console.Write($"the elements of the second 1D array after initilization : ");
            for (int i = 0; i < jaggedArrayTest[1].Length; i++)
            {
                if (jaggedArrayTest[1][i] == null)
                {
                    Console.Write($"null ");
                }
                else
                {
                    Console.Write($"{jaggedArrayTest[1][i]} ");
                }
            }


            //A 2D jagged Array is constructed on the heap with a size to hold 3 1D arrays to hold object references of Quiz.
            //But, we are still to define the total number of object references/elements in each of these 1D arrays.
            Quiz[][] jaggedArrayQuiz = new Quiz[2][];
            //First 1D array will have 2 object references of Quiz
            jaggedArrayQuiz[0] = new Quiz[2];
            //Second 1D array will have 4 object references of Quiz
            jaggedArrayQuiz[1] = new Quiz[4];

            //Reading the elements of the first 1D array before initialization
            Console.WriteLine();
            Console.Write($"the elements of the first 1D array before initilization : ");
            foreach (Quiz item in jaggedArrayQuiz[0])
            {
                if (item == null)
                {
                    Console.Write($"null ");
                }
                else
                {
                    Console.Write($"{item} ");
                }
            }
            //Reading the elements of the second 1D array before initialization
            Console.WriteLine();
            Console.Write($"the elements of the second 1D array before initilization : ");
            foreach (Quiz item in jaggedArrayQuiz[1])
            {
                if (item == null)
                {
                    Console.Write($"null ");
                }
                else
                {
                    Console.Write($"{item} ");
                }
            }

            //Initialization the element of the first 1D array
            for (int i = 0; i < jaggedArrayQuiz[0].Length; i++)
            {
                jaggedArrayQuiz[0][i] = new Quiz();
            }
            //Initialization the element of the second 1D array
            for (int i = 0; i < jaggedArrayQuiz[1].Length; i++)
            {
                jaggedArrayQuiz[1][i] = new Quiz();
            }
            // Reading the elements of first 1D array after initialization

            Console.WriteLine();
            Console.Write($"the elements of first 1D array after initilization :  ");
            foreach (Quiz item in jaggedArrayQuiz[0])
            {
                if (item == null)
                {
                    Console.Write($"null ");
                }
                else
                {
                    Console.Write($"{item} ");
                }
            }
            // Reading the elements of second 1D array after initialization
            Console.WriteLine();
            Console.Write($"the elements of second 1D array after initilization :  ");
            foreach (Quiz item in jaggedArrayQuiz[1])
            {
                if (item == null)
                {
                    Console.Write($"null ");
                }
                else
                {
                    Console.Write($"{item} ");
                }
            }














        }
    }
}