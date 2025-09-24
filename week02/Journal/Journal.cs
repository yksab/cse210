using System;
using System.Collections.Generic;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        newEntry = new Entry();


        Console.Write("Enter ");
        string journalDate = Console.ReadLine();

        Console.Write("Enter journal entry");
        string journalEntry = Console.ReadLine();

        newEntry = new Entry();

        newEntry._date = journalDate;
        newEntry._entryText = journalEntry;
    }

    public void DisplayAll()
    {

    }

    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    {

    }
}