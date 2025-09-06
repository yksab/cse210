using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
    
        DisplayWelcomeMessage();

        string name = PromptUserName();

        int number = PrompUserNumber();

        int square = SquareNumber(number);

        DisplayResult(name, square);
    }      
    

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();

        return name;
    }

    static int PrompUserNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        string response = Console.ReadLine();
        int number = int.Parse(response);
            
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    static void DisplayResult(string name, int squareNumber)
    {
        Console.WriteLine($"Name: {name}, Squre Number: {squareNumber}");
    }
        
}