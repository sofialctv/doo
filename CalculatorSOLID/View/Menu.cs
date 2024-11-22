using System;

namespace CalculatorSOLID.View
{
    public class Menu
    {
        public string GetOperation()
        {
            Console.WriteLine("\nSelect an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter the number of the operation: ");

            var choice = Console.ReadLine();
            return choice switch
            {
                "1" => "add",
                "2" => "subtract",
                "3" => "multiply",
                "4" => "divide",
                _ => throw new ArgumentException("Invalid operation selected.")
            };
        }

        public double GetNumber(string prompt)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out var number))
            {
                return number;
            }
            else
            {
                throw new ArgumentException("Invalid input. Please enter a valid number.");
            }
        }
        public void DisplayResult(double result)
        {
            Console.WriteLine($"The result is: {result}");
        }

        public bool AskToContinue()
        {
            Console.WriteLine("\nDo you want to perform another operation? (y/n)");
            var input = Console.ReadLine()?.Trim().ToLower();
            return input == "y";
        }

        public void DisplayError(string errorMessage)
        {
            Console.WriteLine($"Error: {errorMessage}");
        }
    }
}
