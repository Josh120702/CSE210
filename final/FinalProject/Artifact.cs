using System;

public class Artifact : Card
{
    
    public Artifact(
        string name, 
        string color, 
        int cost,
        string supertype,
        string subtype,
        string rarity)
        : base(name, color, cost, "Artifact",  supertype, subtype, rarity)
    {
        
    }

    public override void Display()
    {
        Console.WriteLine($"{_name} ({_color})");
        Console.WriteLine($"Mana Cost {_cost}");
        Console.WriteLine($"{_supertype} {_type} - {_subtype}");
        Console.WriteLine($"Rarity: {_rarity}");
    }
    public override string GetSaveString()
    {
        return $"Artifact|{_name}|{_color}|{_cost}|{_supertype}|{_type}|{_subtype}|{_rarity}";
    }
}