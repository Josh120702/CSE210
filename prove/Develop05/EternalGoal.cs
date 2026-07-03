using System;

public class EternalGoal : Goal
{
    private int _streak;

    public EternalGoal(string title, string description, int points, int streak = 0)
        : base(title, description, points)
    {
        _streak = streak;
    }

    public override int RecordEvent()
    {
        _streak++;
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void Display()
    {
        Console.WriteLine($"[∞] {_title} ({_description})");
    }

    public override string GetSaveString()
    {
        return $"Eternal|{_title}|{_description}|{_points}|{_streak}";
    }
}