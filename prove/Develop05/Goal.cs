using System;

public abstract class Goal
{
    protected string _title;
    protected string _description;
    protected int _points;

    public Goal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
    }

    public virtual void Display()
    {
        Console.WriteLine($"{_title} ({_description})");
    }

    public abstract int RecordEvent();

    public abstract string GetSaveString();

    public abstract bool IsComplete();
}