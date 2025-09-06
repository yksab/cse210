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

        string code = "";

        if (grade >= 90)
        {
            letter = "A";

            if (grade < 93)
            {
                code = "-";
            }
        }
        else if (grade >= 80)
        {
            letter = "B";

            if (grade < 83)
            {
                code = "-";
            }
            else if (grade >= 87)
            {
                code = "+";
            }
        }
        else if (grade >= 70)
        {
            letter = "C";

            if (grade < 73)
            {
                code = "-";
            }
            else if (grade >= 77)
            {
                code = "+";
            }
        }
        else if (grade >= 60)
        {
            letter = "D";

            if (grade < 63)
            {
                code = "-";
            }
            else if (grade >= 67)
            {
                code = "+";
            }
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"You got a {letter}{code}");

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