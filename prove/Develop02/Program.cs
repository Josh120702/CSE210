using System;

class Program
{
    static void Main(string[] args)
    {
            
            {
            Journal journal = new Journal();

            int choice = 0;
            
            while (choice !=5)
            {
                Console.WriteLine("\nJournal Menu");
                Console.WriteLine("1. Write new entry");
                Console.WriteLine("2. Display the  journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Quit");

                Console.Write("Choose an option: ");
                choice = int.Parse(Console.ReadLine());

            if (choice == 1)
                    {
                        journal.AddEntry();
                    }
            else if (choice == 2)
                    {
                        journal.DisplayEntries();
                    }
            else if (choice == 3)
                    {
                        journal.SaveJournal();
                    }
            else if (choice == 4)
                    {
                        journal.LoadJournal();
                    }
            else if (choice == 5)
                    {
                        Console.WriteLine("Goodbye!");
                    }
            else
                    {
                        Console.WriteLine("Invalid choice.");
                    }
            }
        }
    }
}