using System;

public class Enchantment : Card
{
    
    public Enchantment(
        string name, 
        string color, 
        int cost,
        string supertype,
        string subtype,
        string rarity)
        : base(name, color, cost, "Enchantment", supertype, subtype, rarity)
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
        return $"Enchantment|{_name}|{_color}|{_cost}|{_supertype}|{_type}|{_subtype}|{_rarity}";
    }
}