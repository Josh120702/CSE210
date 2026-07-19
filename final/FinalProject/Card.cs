using System;
using System.Runtime.InteropServices.Marshalling;

public abstract class Card : IComparable<Card>
{
    protected string _name;
    protected string _color;
    protected int _cost;
    protected string _type;
    protected string _supertype;
    protected string _subtype;
    protected string _rarity;

    public Card(
        string name, 
        string color, 
        int cost,
        string type,
        string supertype,
        string subtype,
        string rarity)

        

    {
        _name = name;
        _color = color;
        _cost = cost;
        _type = type;
        _supertype = supertype;
        _subtype = subtype;
        _rarity = rarity;
    }

    public string Name => _name;
    public string Color => _color;
    public int Cost => _cost;
    public string Type => _type;
    public string Rarity => _rarity;

    public int CompareTo(Card other)
{
    int result = _color.CompareTo(other._color);

    if (result != 0) return result;

    result = _type.CompareTo(other._type);

    if (result != 0) return result;

    result = _cost.CompareTo(other._cost);

    if (result != 0) return result;

    return _name.CompareTo(other._name);
}
    public abstract void Display();

    public abstract string GetSaveString();


}