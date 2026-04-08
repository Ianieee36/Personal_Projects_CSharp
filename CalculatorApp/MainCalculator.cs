using System;
using Basic;
using Scientific;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main Console for my Calculator App

        while(true)
            {
                Console.WriteLine("Choose from (1 - 3): ");
                Console.WriteLine("1. Basic Calculator ");
                Console.WriteLine("2. Scientific Calculator ");
                Console.WriteLine("3. Exit ");
                Console.Write("Enter your choice: ");

                string? choice = Console.ReadLine();

                switch(choice)  
                {
                    case "1":
                    MainBasicCal.RunBasicCal();
                    break;

                    case "2":
                    MainScientificCal.RunScientificCal();
                    break;

                    case "3":
                    return;

                    default:
                    Console.WriteLine("Invalid Input!");
                    break;
                }
                Console.WriteLine();

            }
        }
    }
}