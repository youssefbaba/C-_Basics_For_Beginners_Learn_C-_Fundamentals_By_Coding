namespace RefAndOutKeywordTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                // ref :
                     Link1 : https://codewala.net/2016/05/22/passing-a-reference-type-using-ref-keyword/
                     Link2 : https://www.decodejava.com/csharp-ref-parameter.htm
                     link3 : https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref

                // out : 
                     Link1 : https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out-parameter-modifier
                     Link2 : https://www.decodejava.com/csharp-out-parameter.htm

                // differrent between ref and out :
                     link1 : https://www.c-sharpcorner.com/UploadFile/ff2f08/ref-vs-out-keywords-in-C-Sharp/#:~:text=Ref%20and%20out%20keywords%20in,pass%20a%20parameter%20by%20reference.
                     link2 : https://www.youtube.com/watch?v=lYdcY5zulXA&feature=emb_title
             
             
              - Ref :
                - Ref is keyword in C# helps to pass variables by reference
                - The argument must be initialized first before it is passed to ref.
                - It is not required to assign or initialize the value of a parameter (which is passed by ref) before returning to the calling method.
                - When we use REF, data can be passed bi-directionally.
                - Both ref and out are treated differently at run time and they are treated the same at compile time.
                - Properties are not variables, therefore it cannot be passed as an out or ref parameter.
             - Out :
                - Out is keyword in C# helps to pass variables by reference
                - It is not compulsory to initialize a argument before it is passed to an out.
                - A called method is required to assign or initialize a value of a parameter (which is passed to an out) before returning to the calling method.
                - When we use OUT data is passed only in a unidirectional way (from the called method to the caller method).
                - Both ref and out are treated differently at run time and they are treated the same at compile time.
                - Properties are not variables, therefore it cannot be passed as an out or ref parameter.

            */


            // Ref Keyword
            int studentGrade = 75; // Value type
            GiveExtratCredit(ref studentGrade);
            Console.WriteLine($"{studentGrade}"); // 78


            int num = 12;
            SquareOne(num);
            Console.WriteLine($"{num}"); // 12


            int num1 = 10;
            SquareTwo(ref num1);
            Console.WriteLine($"{num1}"); // 100

            User user1 = new User { firstName = "Brij", lastName = "Mishra" }; // Reference type
            UpdateUser(user1); // Passing Reference type by value
            Console.WriteLine($"{user1.firstName} , {user1.lastName}"); // bob , john


            User user2 = new User { firstName = "Youssef", lastName = "Baba" }; // Reference type
            UpdateUserTwo(ref user2); // Passing Reference type by reference
            Console.WriteLine($"{user2.firstName} , {user2.lastName}"); // Mohamed , Zidani


            // Out Keyword : Keyword out essentially does the same things like ref keyword , but there are some different .

            int studentGradeOne; // Value type variable
            GiveExtratCreditOne(out studentGradeOne);
            Console.WriteLine($"Outside method : {studentGradeOne}"); // 30


            int added;
            int mult;
            int val1 = 10;
            int val2 = 15;
            AddAndMult(val1, val2, out added, out mult);
            Console.WriteLine($"{val1} + {val2} = {added}");
            Console.WriteLine($"{val1} * {val2} = {mult}");


            TheStruct struct1 = new TheStruct(); // Value type variable
            ShowOut(out struct1); // Passing Reference type by reference
            Console.WriteLine($"Outside method : {struct1.value}"); // Outside method : 20


            TheClass class1 = new TheClass(); // Reference type variable
            ShowOutOne(out class1); // Passing Reference type by reference
            Console.WriteLine($"Outside method : {class1.value}"); // Outside method : 10

            // Using the out parameter to modify a value type.
            int val;
            Program p = new Program();
            p.Update(out val);
            Console.WriteLine($"After calling the Update() method, the value in a is : {val}"); // After calling the Update() method, the value in a is :


            // Using the out parameter to return more than one value from a method.
            int val3 = 457;
            int quotient;
            double remainder;
            Program p1 = new Program();
            p1.Math_Calc(val3, out quotient, out remainder);
            Console.WriteLine($"{val3} / 10 = {quotient}");
            Console.WriteLine($"{val3} % 10 = {remainder}");


            int result;
            //int result = 20;
            int number1 = 2;
            int number2 = 40;
            Add(number1, number2, out result);
            Console.WriteLine($"{number1} + {number2} = {result}");




            int result1 = 10;
            int nbr1 = 5;
            int nbr2 = 12;
            AddOne(nbr1, nbr2, ref result1);
            Console.WriteLine($"{nbr1} + {nbr2} = {result1}");
           























        }
        public static void GiveExtratCredit(ref int grade)
        {
            grade += 3;
        }

        public static void SquareOne(int number)
        {
            number *= number;
            Console.WriteLine($"{number}");  // 144
        }
        public static void SquareTwo(ref int number)
        {
            number *= number;
        }
        public static void UpdateUser(User u)
        {
            u.firstName = "bob";
            u.lastName = "john";
            //try
            //{
            //    u = null;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }
        public static void UpdateUserTwo(ref User u)
        {
            u.firstName = "Mohamed";
            u.lastName = "Zidani";
            //try
            //{
            //    u = null;
            //}
            //catch (Exception exp)
            //{
            //    Console.WriteLine(exp.Message);
            //}

        }
        public static void GiveExtratCreditOne(out int gradeOne)
        {
            gradeOne = 20;
            gradeOne += 10;
            Console.WriteLine($"Inside method : {gradeOne}"); // 30
        }
        public static void AddAndMult(int num1, int num2, out int added, out int mult)
        {
            added = num1 + num2;
            mult = num1 * num2;
        }
        public static void ShowOut(out TheStruct s)
        {
            s = new TheStruct();
            s.value = 20;
            Console.WriteLine($"Inside method : {s.value}"); //  Inside method : 20
        }
        public static void ShowOutOne(out TheClass cl)
        {
            //cl = null;

            cl = new TheClass();
            cl.value = 10;
            Console.WriteLine($"inside method : {cl.value}"); // inside method : 10
        }
        public void Update(out int i)
        {
            i = 30;
        }
        public void Math_Calc(int number, out int quotient, out double remainder)
        {
            quotient = number / 10;
            remainder = number % 10;

        }
        public static void Add(int a, int b, out int y)
        {

            /*
              y = 0;
              Console.WriteLine($"{y}");
              y = a + b;
             */
            y = a + b;
        }
        public static void AddOne(int a , int b , ref int y)
        {
            //a = a + b;
            y = a + b;
        }

    }
}