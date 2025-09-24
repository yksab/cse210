using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry()
    {
        DateTime now = DateTime.Now;
        _date = now.ToString(); 
    }

    public void Display()
    {
        Console.WriteLine(_date + ", " + _promptText + ", " + _entryText);
    }
}