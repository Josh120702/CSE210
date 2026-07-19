using System;

public class Creature : Card

{
    private int _power;
    private int _toughness;
    

    public Creature(
        string name, 
        string color, 
        int cost,
        string supertype,
        string subtype,
        string rarity,
        int power,
        int toughness) 
        : base(name, color, cost, "Creature",supertype, subtype, rarity)
    {
        _power = power;
        _toughness = toughness;
    }
    public override void Display()
    {
        Console.WriteLine($"{_name} ({_color})");
        Console.WriteLine($"Mana Cost {_cost}");
        Console.WriteLine($"Power/Toughness {_power}/{_toughness}");
    }

    public override string GetSaveString()
    {
        return $"Creature|{_name}|{_color}|{_cost}|{_supertype}|{_type}|{_subtype}|{_rarity}|{_power}/{_toughness}";
    }

}