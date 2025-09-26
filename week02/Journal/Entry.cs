using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry()
    {
        DateTime now = DateTime.Now;
        _date = String.Format("{0:f}", now);
    }

    public void Display()
    {
        Console.WriteLine(_date + ":" + _promptText + "\t" + _entryText);
    }
}