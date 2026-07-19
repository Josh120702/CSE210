using System;

public class Land : Card
{
    
    public Land(
        string name, 
        string color, 
        string supertype,
        string subtype,
        string rarity)
        : base(name, color, 0, "Land", supertype, subtype, rarity)
    {
        
    }

    
    public override void Display()
    {
        Console.WriteLine($"{_name} ({_color})");
        Console.WriteLine($"{_supertype} {_type} - {_subtype}");
        Console.WriteLine($"Rarity: {_rarity}");
        
    }
    public override string GetSaveString()
    {
        return $"Land|{_name}|{_color}|{_cost}|{_supertype}|{_type}|{_subtype}|{_rarity}";
    }
}