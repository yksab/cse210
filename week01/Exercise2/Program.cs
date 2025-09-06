using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
    
        Console.Write("Enter your grade percentage? ");
        string number = Console.ReadLine();
        int grade = int.Parse(number);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"You got a {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congrats you passed");
        }
        else
        {
            Console.WriteLine("Well, try again next time.");
        }
        
    }


}