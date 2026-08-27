using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            Console.WriteLine("Sum: " + (num1 + num2));
            Console.WriteLine("Subtraction: " + (num1 - num2));
            Console.WriteLine("Multiplication: " + (num1 * num2));

            if (num2 == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            else
            {
                Console.WriteLine("Division: " + (num1 / num2));
            }

            Console.Write("Do you want to calculate again? (y/n): ");
            string? answer = Console.ReadLine();

            if (answer?.ToLower() != "y")
                break;
        }
    }
}