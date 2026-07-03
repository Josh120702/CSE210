using System;

class Program
{
    static void Main()
    {
        GoalList goalList = new GoalList();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine($"Current Score: {goalList.Score}");
            Console.WriteLine();

            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(goalList);
                    break;

                case "2":
                    goalList.DisplayGoals();
                    break;

                case "3":
                    goalList.DisplayGoals();
                    Console.Write("Goal number: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    goalList.RecordGoal(index);
                    break;

                case "4":
                    Console.Write("Filename: ");
                    goalList.SaveGoals(Console.ReadLine());
                    break;

                case "5":
                    Console.Write("Filename: ");
                    goalList.LoadGoals(Console.ReadLine());
                    break;

                case "6":
                    return;
            }
        }
    }

    static void CreateGoal(GoalList goalList)
    {
        Console.WriteLine();
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Choice: ");
        string type = Console.ReadLine();

        Console.Write("Title: ");
        string title = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                goalList.AddGoal(new SimpleGoal(title, description, points));
                break;

            case "2":
                goalList.AddGoal(new EternalGoal(title, description, points));
                break;

            case "3":
                Console.Write("Times to complete: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine());

                goalList.AddGoal(new ChecklistGoal(title, description, points, target, bonus));
                break;
        }
    }
}