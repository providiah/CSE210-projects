using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("\n=== Journal Menu ===");
            Console.WriteLine("1. write New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Show Statistics");
            Console.WriteLine("6. Quit");

            Console.Write("Make a Choice: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        WriteEntry(journal, promptGenerator);
                        break;

                    case 2:
                        journal.DisplayAll();
                        break;

                    case 3:
                        SaveJournal(journal);
                        break;

                    case 4:
                        LoadJournal(journal);
                        break;

                    case 5:
                        journal.ShowStatistics();
                        break;

                    case 6:
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }

    static void WriteEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("> ");
        string response = Console.ReadLine();

        Console.Write("What is your mood today? ");
        string mood = Console.ReadLine();

        Entry entry = new Entry();

        entry._date = DateTime.Now.ToShortDateString();
        entry._promptText = prompt;
        entry._entryText = response;
        entry._mood = mood;

        journal.AddEntry(entry);

        Console.WriteLine("Journal entry added successfully.");
    }

    static void SaveJournal(Journal journal)
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        journal.SaveToFile(filename);
    }

    static void LoadJournal(Journal journal)
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        journal.LoadFromFile(filename);
    }
}