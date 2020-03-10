using System;

namespace domasni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 3 please!");
            string numberInput = Console.ReadLine();
            switch (numberInput)
            {
                case "1":
                    Console.WriteLine("You got a new car!");
                    break;
                case "2":
                    Console.WriteLine("You got a new plane!");
                    break;
                case "3":
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine("Please enter a number between 1 and 3!");
                    break;
            }
            Console.WriteLine("Please enter two numbers");
            string numberOne = Console.ReadLine();
            string numberTwo = Console.ReadLine();
            int numberOneInt = int.Parse(numberOne);
            int numberTwoInt = int.Parse(numberTwo);
            if (numberOneInt > numberTwoInt) 
            {
                Console.WriteLine("Number one is bigger than number two");
                if (numberOneInt % 2 == 0)
                {
                    Console.WriteLine("Number one is even");
                }
                else
                {
                    Console.WriteLine("Number one is odd");
                };
            }
            else
            {
                Console.WriteLine("Number two is bigger than number one");
                if (numberTwoInt % 2 == 0)
                {
                    Console.WriteLine("Number two is even");
                }
                else
                {
                    Console.WriteLine("Number two is odd");
                }
            };
            int branchesOnOneTree = 12;
            int numberOfApples = 8;
            int basketCap = 5;
            Console.WriteLine("Enter number of trees");
            string userInputTrees = Console.ReadLine();
            int numberOfBaskets = int.Parse(userInputTrees) * branchesOnOneTree * numberOfApples / basketCap;
            Console.WriteLine(numberOfBaskets);
            Console.ReadLine();
        }
    }
}
