using System;

public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string title, string description, int points, bool completed = false)
        : base(title, description, points)
    {
        _completed = completed;
    }

    public override int RecordEvent()
    {
        if (!_completed)
        {
            _completed = true;
            return _points;
        }

        return 0;
    }

    public override bool IsComplete()
    {
        return _completed;
    }

    public override void Display()
    {
        string check = _completed ? "[X]" : "[ ]";
        Console.WriteLine($"{check} {_title} ({_description})");
    }

    public override string GetSaveString()
    {
        return $"Simple|{_title}|{_description}|{_points}|{_completed}";
    }
}