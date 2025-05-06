using System;
using System.Security.Principal;

public class Calculator
{
    public int num1;
    public int num2;
}

class Program
{
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.Clear();
        Console.WriteLine("Enter 1st number :");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter 2nd number :");
        int num2 = int.Parse(Console.ReadLine());

        Calculator calculator = new Calculator();
        while (true) {
            Console.WriteLine("\nOPERATORS");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            Console.WriteLine("Enter your choice :");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("You chose ADDITION");
                    Console.Write($"\n{num1} + {num2} = {num1 + num2}");
                    break;
                case "2":
                    Console.Write("You chose SUBSTRACTION");
                    Console.Write($"\n{num1} -{num2} = {num1 - num2}");
                    break;
                case "3":
                    Console.Write("You chose MULTIPLICATION");
                    Console.Write($"\n{num1} * {num2} = {num1*num2}");
                    break;
                case "4":
                    try
                    {
                        Console.WriteLine($"You chose DIVISION: {num1} / {num2} = {num1 / num2}");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine($"{num1} / {num2} = INFINITY");
                    }
                    break;
                case "5":
                    Console.WriteLine("Exiting program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option");
                    break;

            }
        }
        }
    }
