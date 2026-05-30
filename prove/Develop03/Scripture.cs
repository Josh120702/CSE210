using System;
using System.Collections.Generic;

public class Scripture
{
    private List<Word> _words;
    private Reference _reference;
    private Random _random = new Random();
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }
    public void Display()
    {
        Console.WriteLine(_reference.Display());
        foreach (Word word in _words)
        {
            Console.Write(word.Display() + " ");
        }
        Console.WriteLine();
    }
    public void HideRandomWords(int count)
    {
        for (int i = 0; i < count; i++)
        {
            int index = _random.Next(_words.Count);
            _words[index].Hide();
        }
    }
    public bool AllHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}