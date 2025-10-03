using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;

        int number = _text.Length;

        string newWord = "";
        newWord = newWord.PadLeft(number, '_');
        newWord = String.Join(" ", newWord);
        _text = newWord.Trim();
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        if (_isHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetDisplayText()
    {
        return _text;
    }
}