using System;
using System.ComponentModel.Design.Serialization;

public class Land : Card
{
    
    public Land(
        string name, 
        string color, 
        string supertype,
        string subtype,
        string rarity)
        : base(name, color, 0, supertype, "Land", subtype, rarity)
    {
        
    }

    
    public override void Display()
    {
        Console.WriteLine($"{_name} ({_color})");
        
    }
    public override string GetSaveString()
    {
        return $"Land|{_name}|{_color}|{_supertype}|{_type}|{_subtype}|{_rarity}";
    }
}