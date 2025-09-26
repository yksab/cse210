using System;
using System.Collections.Generic;
using System.IO;

//the only thing I added was to clear the _entries list after u hav saved the file (line 35). Its a simple fix, because I think when u save a file then everything in the list should be clear. I think that just make sense

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry i in _entries)
        {
            Console.WriteLine(i._date + ", " + i._promptText + "/n" + i._entryText);
        }
    }

    public void SaveToFile(string file)
    {
        string filename = file + ".txt";

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry i in _entries)
            {
                writer.WriteLine(i._date + "," + i._promptText + "," + i._entryText);
            }
        }

        _entries.Clear();
    }

    public void LoadFromFile(string file)
    {
        string filename = file + ".txt";

        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];

            _entries.Add(newEntry);
        }
    }
}

