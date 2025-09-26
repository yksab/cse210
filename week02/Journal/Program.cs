using System;
using System.Net;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Progammmmmmiing";

        int choice= -1;
        
        Journal newJournal = new Journal();
        PromptGenerator newPrompt = new PromptGenerator();

        while (choice != 5)
        {
            Console.WriteLine("Menu\n1. new entry\n2. Display journal\n3. Save journal entries\n4. load journal\n5. Quit");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = newPrompt.GetRandomPrompt();
                Console.WriteLine(prompt);

                Entry newEntry = new Entry();
                newEntry._promptText = prompt;

                Console.WriteLine("enter journal entry");
                newEntry._entryText = Console.ReadLine();

                newJournal.AddEntry(newEntry);
            }
            else if (choice == 2)
            {
                newJournal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.WriteLine("Enter a filename");
                string saveFilename = Console.ReadLine();

                newJournal.SaveToFile(saveFilename);
            }
            else if (choice == 4)
            {
                Console.WriteLine("Enter a filename");
                string loadFilename = Console.ReadLine();

                newJournal.LoadFromFile(loadFilename);
            }
            else if (choice == 5)
            {
                continue;
            }
            else
            {
                Console.WriteLine("wrong button, try again");
            }
        }   
    }
}
