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
        : base(name, color, cost, supertype, spellType, subtype, rarity)
    {
        
    }

    public override void Display()
    {
        Console.WriteLine($"{_name} ({_color})");
        Console.WriteLine($"Mana Cost {_cost}");
        
    }
    public override string GetSaveString()
    {
        return $"Spells|{_name}|{_color}|{_cost}|{_supertype}|{_type}|{_subtype}|{_rarity}";
    }
}