using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            newWord.Show();

            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int count = 0;

        foreach (Word word in _words)
        {
            count += 1;
        }

        int countTotal = count - 1;

        int counter = 1;

        while ((counter != numberToHide) || (IsCompletelyHidden() == true))
        {
            Random randomNumber = new Random();
            int number = randomNumber.Next(0, countTotal);

            bool isHidden = _words[number].IsHidden();

            if (isHidden == false)
            {
                counter++;

                _words[number].Hide();
            }

            if (IsCompletelyHidden())
            {
                break;
            }            
        }
    }

    public string GetDisplayText()
    {
        string a = _reference.GetDisplay();

        int numWords = _words.Count();

        List<string> b = new List<string>();

        foreach (Word word in _words)
        {
            string c = word.GetDisplayText();
            b.Add(c);
        }

        
        
        

        return a + "\n\n" + (b );
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            bool isHidden = word.IsHidden();

            if (isHidden == false)
            {
                return false;
            }
        }

        return true;
    }
}