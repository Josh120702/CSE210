using System;

public class Spells : Card
{
    
    public Spells(
        string name, 
        string color, 
        int cost,
        string spellType,
        string supertype,
        string subtype,
        string rarity)
        : base(name, color, cost, spellType, supertype, subtype, rarity)
    {
        
    }

    public override void Display()
    {
        Console.WriteLine($"{_name} ({_color})");
        Console.WriteLine($"Mana Cost {_cost}");
        Console.WriteLine($"{_supertype} {_type}");
        Console.WriteLine($"Subtype: {_subtype}");
        Console.WriteLine($"Rarity: {_rarity}");

    }
    public override string GetSaveString()
    {
        return $"Spells|{_name}|{_color}|{_cost}|{_supertype}|{_type}|{_subtype}|{_rarity}";
    }
}