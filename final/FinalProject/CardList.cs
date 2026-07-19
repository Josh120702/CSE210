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
        }
    }

    public void DisplayList()
    {
        foreach (Card card in _list)
        {
            card.Display();
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
    }

    public void LoadCard(string filname)
    {
        
        
            
        
    }

    public void SortCards()
{
    _list.Sort();
}
}
