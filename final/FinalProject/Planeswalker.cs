using System;

public class Planeswalker : Card
{
    private int _loyalty;
    public Planeswalker(
        string name, 
        string color, 
        int cost,
        string supertype,
        string subtype,
        string rarity,
        int loyalty)
        : base(name, color, cost, "Planeswalker",  supertype, subtype, rarity)
    {
        _loyalty = loyalty;
    }

    public override void Display()
    {
        Console.WriteLine($"{_name} ({_color})");
        Console.WriteLine($"Mana Cost {_cost}");
        Console.WriteLine($"{_supertype} {_type} - {_subtype}");
        Console.WriteLine($"Loyalty {_loyalty}");
        Console.WriteLine($"Rarity: {_rarity}");
    }
    public override string GetSaveString()
    {
        return $"Planeswalker|{_name}|{_color}|{_cost}|{_supertype}|{_type}|{_subtype}|{_rarity}|{_loyalty}";
    }
}