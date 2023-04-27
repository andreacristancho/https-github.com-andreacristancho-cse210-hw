using System;

class Program
{
    static void Main(string[] args)

    {
        DisplayWelcome();

        string UserName = PromptUserName();

        int UserNumber = PromptUserNumber();

        int Square = SquareNumber(UserNumber);

        DisplayFinalMessage(UserName,Square);
    }


    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program. ");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

     static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your number: ");
        string num = Console.ReadLine();
        int number = int.Parse(num);

        return number;
    }

    static int SquareNumber(int number)
    {
        
        int square = number * number;

        return square;

    }

    static void DisplayFinalMessage(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

}