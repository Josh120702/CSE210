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
        : base(name, color, cost, supertype, "Artifact", subtype, rarity)
    {
        
    }

    public override void Display()
    {
        Console.WriteLine($"{_name} ({_color})");
        Console.WriteLine($"Mana Cost {_cost}");
    }
    public override string GetSaveString()
    {
        return $"Artifact|{_name}|{_color}|{_cost}|{_supertype}|{_type}|{_subtype}|{_rarity}";
    }
}