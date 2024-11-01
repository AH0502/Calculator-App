using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueCalculation = True;
            Console.WriteLine("Welcome to the calculator!")

            while (continueCalculation)
            {
                Console.WriteLine("\nSelect an operation: ");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Divison (/)");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine("Enter Choice: ")

                if (choice == "5")
                {
                    continueCalculation = false;
                    Console.WriteLine("Thank you for using the calculator.")
                
                }

                if (choice == "1")
            }
        }
    }
}