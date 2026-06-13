using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        // Creativity:
        // Added a level system.
        // Every 1000 points increases the player's level.

        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine($"Score: {manager.GetScore()}");
            Console.WriteLine($"Level: {manager.GetLevel()}");
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

                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");

                    string type = Console.ReadLine();

                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Description: ");
                    string description = Console.ReadLine();

                    Console.Write("Points: ");
                    int points = int.Parse(Console.ReadLine());

                    if (type == "1")
                    {
                        manager.AddGoal(
                            new SimpleGoal(
                                name,
                                description,
                                points));
                    }
                    else if (type == "2")
                    {
                        manager.AddGoal(
                            new EternalGoal(
                                name,
                                description,
                                points));
                    }
                    else if (type == "3")
                    {
                        Console.Write("Target: ");
                        int target = int.Parse(Console.ReadLine());

                        Console.Write("Bonus: ");
                        int bonus = int.Parse(Console.ReadLine());

                        manager.AddGoal(
                            new ChecklistGoal(
                                name,
                                description,
                                points,
                                target,
                                bonus));
                    }

                    break;

                case "2":
                    manager.ListGoals();
                    break;

                case "3":

                    manager.ListGoals();

                    Console.Write("Which goal completed? ");
                    int index =
                        int.Parse(Console.ReadLine()) - 1;

                    manager.RecordEvent(index);

                    break;

                case "4":

                    Console.Write("Filename: ");
                    string saveFile =
                        Console.ReadLine();

                    manager.SaveGoals(saveFile);

                    Console.WriteLine("Saved.");

                    break;

                case "5":

                    Console.Write("Filename: ");
                    string loadFile =
                        Console.ReadLine();

                    manager.LoadGoals(loadFile);

                    Console.WriteLine("Loaded.");

                    break;

                case "6":
                    running = false;
                    break;
            }
        }
    }
}