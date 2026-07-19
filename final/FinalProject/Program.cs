using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main()
    {
        CardList cardList = new CardList();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Magic the Gathering Sort Card List App.");
            Console.WriteLine("Add cards to a list then try sorting them.");
            Console.WriteLine();
            Console.WriteLine("1. Create Card List");
            Console.WriteLine("2. Add Card");
            Console.WriteLine("3. Save Card");
            Console.WriteLine("4. Remove Card");
            Console.WriteLine("5. Load Card List");
            Console.WriteLine("6. Sort Card List");
            Console.WriteLine("7. Quit");

            Console.Write("Choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    cardList = new CardList();
                    Console.WriteLine("New card list created.");
                    break;

                case "2":
                    AddCard(cardList);
                    break;

                case "3":
                    Console.Write("Enter filename: ");
                    string saveFile = Console.ReadLine();
                    cardList.SaveCard(saveFile);
                    break;
                case "4":
                    RemoveCard(cardList);
                    break;


                case "5":
                    Console.Write("Enter filename: ");
                    string loadFile = Console.ReadLine();
                    cardList.LoadCard(loadFile);
                    cardList.DisplayList();
                    break;

                case "6":
                    cardList.SortCards();
                    Console.WriteLine("Cards sorted.");
                    cardList.DisplayList();
                    break;

                case "7":
                    return;
            }

            static void AddCard(CardList cardList)
            {
                Console.WriteLine("Select Card Type:");
                Console.WriteLine("1. Creature");
                Console.WriteLine("2. Artifact");
                Console.WriteLine("3. Enchantment");
                Console.WriteLine("4. Planeswalker");
                Console.WriteLine("5. Spell");
                Console.WriteLine("6. Land");

                Console.Write("Choice: ");
                string choice = Console.ReadLine();

                int cost = 0;

                if (choice != "6")  
                {
                    Console.Write("Mana Cost: ");
                    cost = int.Parse(Console.ReadLine());
                }

                string spellType = "";

                if (choice == "5")
                {
                    Console.WriteLine("Spell Type Instant or Sorcery: ");
                    spellType = Console.ReadLine();
                }

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Color: ");
                string color = Console.ReadLine();
                

                Console.Write("Supertype: ");
                string supertype = Console.ReadLine();


                Console.Write("Subtype: ");
                string subtype = Console.ReadLine();

                Console.Write("Rarity: ");
                string rarity = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        Console.Write("Power: ");
                        int power = int.Parse(Console.ReadLine());
                        Console.Write("Toughness: ");
                        int toughness = int.Parse(Console.ReadLine());

                        cardList.AddCard(new Creature(
                            name, color, cost, supertype, subtype, rarity, power, toughness));
                            break;
                    case "2":
                        cardList.AddCard(new Artifact(
                            name, color, cost, supertype, subtype, rarity));
                        break;
                    case "3":
                        cardList.AddCard(new Enchantment(
                            name, color, cost, supertype, subtype, rarity));
                        break;
                    case "4":
                        Console.Write("Loyalty: ");
                        int loyalty = int.Parse(Console.ReadLine());
                        cardList.AddCard(new Planeswalker(
                            name, color, cost, supertype, subtype, rarity, loyalty));
                        break;
                    case "5":
                        cardList.AddCard(new Spells(
                            name, color, cost, supertype, spellType, subtype, rarity));
                        break;
                    case "6":
                        cardList.AddCard(new Land(
                            name, color, supertype, subtype, rarity));
                        break;

                }
            }

            static void RemoveCard(CardList cardList)
            {
                cardList.DisplayList();
                Console.Write("Enter card number to remove: ");
                if (int.TryParse(Console.ReadLine(), out int index))
                {
                    cardList.RemoveCard(index - 1);
                }
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}