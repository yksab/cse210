using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Progammmmmmiing";

        Console.Write("Menu\n1. new entry\n2. Display journal\n3. save journal\n4.load jornal");

        int choice = int.Parse(Console.ReadLine());

        Journal myJournal = new Journal();
        PromptGenerator messagePrompt = new PromptGenerator();


        if (choice == 1)
        {

            Console.WriteLine(messagePrompt.GetRandomPrompt());

            Console.WriteLine("Write a new entry");

            string dataM = (Console.ReadLine());


            Console.WriteLine("Name yr new entry");


            myJournal.AddEntry(dataM);








            int newEntry = Convert.ToInt(Console.ReadLine());

            string response = Journal.AddEntry(newEntry);


        }
        else if (choice == 2)
        {
            //
        }
        else if (choice == 3)
        {
            //
        }
        else if (choice == 4)
        {
            //
        }

    }
}