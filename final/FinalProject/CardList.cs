using System;

class CardList
{
    private List<Card> _list = new List<Card>();
    private bool _saved;
    private bool _loaded;


    public CardList()
    {
        _saved = false;
        _loaded = false;
    }

    public bool IsSaved => _saved;
    public bool IsLoaded => _loaded;
    public void AddCard(Card card)
    {
        _list.Add(card);
        _saved = false;
    }

    public void RemoveCard(int index)
    {
        if (index >= 0 && index < _list.Count)
        {
            _list.RemoveAt(index);
            _saved = false;
            Console.WriteLine("Card removed.");
        }
        else
    {
        Console.WriteLine("Invalid card number.");
    }
    }

    public void DisplayList()
    {
        for (int i = 0; i < _list.Count; i++)
    {
        Console.Write($"{i + 1}. ");
        _list[i].Display();
        Console.WriteLine();
        }
    }

    public void SaveCard(string filename)
    {
        using (StreamWriter output = new StreamWriter(filename))
        {
            foreach (Card card in _list)
            {
                output.WriteLine(card.GetSaveString());
            }
        }
        _saved = true;
        Console.WriteLine("Card list saved successfully.");
    }

    public void LoadCard(string filename)
    {
        if (!File.Exists(filename))
    {
        Console.WriteLine("File not found.");
        return;
    }
        _list.Clear();

    string[] lines = File.ReadAllLines(filename);

    foreach (string line in lines)
        {
            string[] parts = line.Split('|');

        switch (parts[0])
        {
            case "Creature":

                string[] stats = parts[8].Split('/');

                _list.Add(new Creature(
                    parts[1],                   // name
                    parts[2],                   // color
                    int.Parse(parts[3]),        // cost
                    parts[4],                   // supertype
                    parts[6],                   // subtype
                    parts[7],                   // rarity
                    int.Parse(stats[0]),        // power
                    int.Parse(stats[1])));      // toughness

                break;

            case "Artifact":
                _list.Add(new Artifact(
                    parts[1],                // name
                    parts[2],                // color
                    int.Parse(parts[3]),     // cost
                    parts[4],                // supertype
                    parts[6],                // subtype
                    parts[7]));              // rarity
                break;

            case "Enchantment":
                _list.Add(new Enchantment(
                    parts[1],                // name
                    parts[2],                // color
                    int.Parse(parts[3]),     // cost
                    parts[4],                // supertype
                    parts[6],                // subtype
                    parts[7]));              // rarity
                break;

            case "Planeswalker":
                _list.Add(new Planeswalker(
                    parts[1],                // name
                    parts[2],                // color
                    int.Parse(parts[3]),     // mana cost
                    parts[4],                // supertype
                    parts[6],                // subtype
                    parts[7],                // rarity
                    int.Parse(parts[8])));   // loyalty
                break;

            case "Spells":
                _list.Add(new Spells(
                    parts[1],                // name
                    parts[2],                // color
                    int.Parse(parts[3]),     // cost
                    parts[5],                // spellType (Instant/Sorcery)
                    parts[4],                // supertype
                    parts[6],                // subtype
                    parts[7]));              // rarity
                break;

            case "Land":
                _list.Add(new Land(
                    parts[1],    // name
                    parts[2],    // color
                    parts[4],    // supertype
                    parts[6],    // subtype
                    parts[7]));  // rarity
                break;
                    }
                    
                        
                    
                    }
            _loaded = true;
            _saved = true;

            Console.WriteLine("Card list loaded successfully.");
                }

    public void SortCards()
{
    _list.Sort();
}
}
