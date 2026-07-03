using System;

public class ChecklistGoal : Goal
{
    private int _completed;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string title, string description, int points, int target, int bonus, int completed = 0)
        : base(title, description, points)
    {
        _target = target;
        _bonus = bonus;
        _completed = completed;
    }

    public override int RecordEvent()
    {
        if (_completed >= _target)
            return 0;

        _completed++;

        if (_completed == _target)
            return _points + _bonus;

        return _points;
    }

    public override bool IsComplete()
    {
        return _completed >= _target;
    }

    public override void Display()
    {
        string check = IsComplete() ? "[X]" : "[ ]";

        Console.WriteLine($"{check} {_title} ({_description}) -- Completed {_completed}/{_target}");
    }

    public override string GetSaveString()
    {
        return $"Checklist|{_title}|{_description}|{_points}|{_completed}|{_target}|{_bonus}";
    }
}