using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs",3, 5, 6);

        Scripture scripture = new Scripture(
            reference,
            "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths"
        );

        while (!scripture.AllHidden())
        {
            Console.Clear();
            scripture.Display();

            Console.WriteLine();
            Console.Write("Press Enter to continue or type quit: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                return;
            }
            scripture.HideRandomWords(3);
        }
        Console.Clear();
        scripture.Display();
        Console.WriteLine("\nAll words are hidden.");
    }
}