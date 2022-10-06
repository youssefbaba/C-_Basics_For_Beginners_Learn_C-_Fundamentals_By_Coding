namespace ControlFlowLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - link1 : https://www.youtube.com/watch?v=5xlc9qzOQmk&list=PLAC325451207E3105&index=13
             - link2 :
             */



            // First Way
            Console.Write("Please enter an integer number : ");
            int numberOne;
            bool converted = Int32.TryParse(Console.ReadLine(), out numberOne);
            if (converted)
            {
                int counter = 0;
                Console.Write($"Even numbers between 0 and {numberOne} : ");
                while (counter <= numberOne)
                {
                    if ((counter % 2) == 0)
                    {
                        Console.Write($"{counter} ");
                    }
                    counter++;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Conversion Failed.");
            }

            // Second way
            Console.Write("Please enter an integer number : ");
            int numberTwo;
            bool check = Int32.TryParse(Console.ReadLine(), out numberTwo);
            if (check)
            {
                int index = 0;
                Console.Write($"Even numbers between 0 and {numberOne} : ");
                while (index <= numberTwo)
                {
                    Console.Write($"{index} ");
                    index += 2;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Conversion Failed.");
            }

            string userChoise = string.Empty;
            do
            {
                Console.Write("Please enter your target number : ");
                int numberThree;
                if (Int32.TryParse(Console.ReadLine(), out numberThree))
                {
                    int counter = 0;
                    Console.Write($"The even numbers between 0 and {numberThree} : ");
                    while (counter <= numberThree)
                    {
                        if ((counter % 2) == 0)
                        {
                            Console.Write($"{counter} ");
                        }
                        counter++;
                    }
                    Console.WriteLine();
                    do
                    {
                        Console.Write("Please do you want to continue - Yes or No : ");
                        userChoise = Console.ReadLine();
                        if (!userChoise.Equals("Yes", StringComparison.OrdinalIgnoreCase) && !userChoise.Equals("No", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Invalid choise please say Yes or No .");
                        }

                    } while (!userChoise.Equals("Yes", StringComparison.OrdinalIgnoreCase) && !userChoise.Equals("No", StringComparison.OrdinalIgnoreCase));
                }
                else
                {
                    Console.WriteLine("Conversion failed");
                }
            } while (userChoise.Equals("Yes", StringComparison.OrdinalIgnoreCase));

            int totalCoffeCost = 0;
            string userDecision = string.Empty;
            do
            {
                int sizeCoffe;
                do
                {
                    Console.Write("Please select your coffe size : 1 -> Small, 2 -> Medium, 3 -> Large : ");
                    if (int.TryParse(Console.ReadLine(), out sizeCoffe))
                    {
                        switch (sizeCoffe)
                        {
                            case 1:
                                totalCoffeCost++;
                                break;
                            case 2:
                                totalCoffeCost += 2;
                                break;
                            case 3:
                                totalCoffeCost += 3;
                                break;
                            default:
                                Console.WriteLine($"Your choice {sizeCoffe} is invalid");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Conversion from string to int failed .");
                    }
                } while (sizeCoffe != 1 && sizeCoffe != 2 && sizeCoffe != 3);

                do
                {
                    Console.Write("Do you want to buy another coffe - Yes or No : ");
                    userDecision = Console.ReadLine();
                    if (!userDecision.Equals("Yes", StringComparison.OrdinalIgnoreCase) && !userDecision.Equals("No", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Your choice '{userDecision}' is invalid , please say Yes or No");
                    }
                } while (!userDecision.Equals("Yes", StringComparison.OrdinalIgnoreCase) && !userDecision.Equals("No", StringComparison.OrdinalIgnoreCase));
            } while (userDecision.Equals("Yes", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Thank you for shoping with us");
            Console.WriteLine($"Bill Amount = {totalCoffeCost} $");

            int[] numbers = new int[] {101,102,103};

            // using while loop :
            Console.WriteLine("########### using while loop ########### ");
            int ind = 0;
            while (ind < numbers.Length)
            {
                Console.WriteLine($"Element[{ind}] of array numbers is {numbers[ind]}");
                ind++;
            }

            Console.WriteLine("########### using for loop ########### ");
            // using for loop :
            for (int  j  = 0; j < numbers.Length ; j++)
            {
                Console.WriteLine($"Element[{j}] of array numbers is {numbers[j]}");
            }
            Console.WriteLine("########### using foreach loop ########### ");
            int k = 0;
            foreach (int number in numbers)
            {
                Console.WriteLine($"Element[{k}] of array numbers is {number}");
                k++;
            }

            // Display Numbers bettween 0 and 10
            // first way
            Console.Write("Numbers bettween 0 and 10 : ");
            for (int i = 0; i <= 20 ; i++)
            {
                Console.Write($"{i} ");
                if (i == 10)
                {
                    break;
                }
            }
            Console.WriteLine();
            // Second way 
            Console.Write("Numbers bettween 0 and 10 : ");
            for (int i = 0; i <= 30 ; i++)
            {
                if (i <= 10)
                {
                    Console.Write($"{i} ");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine();
            // Display even numbers  bettwenn 0 and 20
            // first way 
            Console.Write("Even Numbers bettween 0 and 20 : ");
            for (int i = 0; i <= 20; i++)
            {
                if ( (i % 2) == 0 )
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
            // Second way 
            Console.Write("Even Numbers bettween 0 and 20 : ");
            for (int i = 0; i <= 20; i++)
            {
                if ( (i % 2) != 0 )
                {
                    continue;
                }
                Console.Write($"{i} ");
            }
            Console.WriteLine();






















        }
    }
}