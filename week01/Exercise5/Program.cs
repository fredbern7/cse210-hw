using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int number = PromptUserNumber();
        int squareRoot = SquareNumber(number);

        DisplayResult(userName, squareRoot);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name here: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your name here: ");
        string number = Console.ReadLine();
        int favNumber = int.Parse(number);
        return favNumber;
    }

    static int SquareNumber(int number)
    {
        int result = number * number;
        return result;
    }

    static void DisplayResult(string userName, int squareRoot)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareRoot}");
    }


}