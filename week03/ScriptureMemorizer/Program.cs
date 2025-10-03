using System;
using System.ComponentModel;
using System.Net;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n\nWelcome to learning the scripture memorizer\n");

        Console.WriteLine("\nType scripture book?");
        string book = Console.ReadLine();

        Console.WriteLine("\nType chapter number?");
        int chapter = int.Parse(Console.ReadLine());

        Console.WriteLine("\nType the first verse");
        int startVerse = int.Parse(Console.ReadLine());

        Console.WriteLine("and the last verse it covers. If it doesn't have a verse range then just type '0' for no other verses");

        int choiceVerse = int.Parse(Console.ReadLine());

        Reference newReference;

        if (choiceVerse != 0)
        {
            int endVerse = choiceVerse;
            newReference = new Reference(book, chapter, startVerse, endVerse);
        }
        else
        {
            newReference = new Reference(book, chapter, startVerse);
        }

        Console.WriteLine("\nEnter scripture text (no comma's or full stop; just spaces)");
        string scriptureText = Console.ReadLine();

        Scripture newScripture = new Scripture(newReference, scriptureText);

        // Console.WriteLine("\nHow many words do u want to hide?");
        // int numHideWords = int.Parse(Console.ReadLine());

        int numHideWords = 1;

        bool decisionContinue = true;

        // Console.Clear();

        do
        {
            Console.WriteLine(newScripture.GetDisplayText());

            Console.WriteLine("\nPress enter to continue to memorize scripture or type 'quit' to exit program");

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                newScripture.HideRandomWords(numHideWords);

                Console.Clear();

                Console.WriteLine(newScripture.GetDisplayText());

                if (newScripture.IsCompletelyHidden() == true)
                {
                    decisionContinue = false;
                }
            }
            else if (Console.ReadLine() == "quit")
            {
                decisionContinue = false;
            }
        }
        while (decisionContinue == false);
    }
}
    

