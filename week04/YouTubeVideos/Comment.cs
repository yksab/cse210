using System;

public class Comment
{
    private string _name;
    private string _entryText;

    public Comment(string name, string entryText)
    {
        _name = name;
        _entryText = entryText;
    }

    public string DisplayComments()
    {
        return "\nCOMMENTS\nName:\t" + _name + "\nComment: " + _entryText;
    }
}