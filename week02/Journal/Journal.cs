using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries available.");
            return;
        }

        Console.WriteLine("\n=== Journal Entries ===");

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        try
        {
            string json = JsonSerializer.Serialize(
                _entries,
                new JsonSerializerOptions { WriteIndented = true}
            );

            File.WriteAllText(filename, json);

            Console.WriteLine("Journal saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    public void LoadFromFile(string filename)
    {
        try
        {
            if (File.Exists(filename))
            {
                string json = File.ReadAllText(filename);

                _entries = JsonSerializer.Deserialize<List<Entry>>(json);

                Console.WriteLine("Journal loaded successfully.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }

    public void ShowStatistics()
    {
        Console.WriteLine($"\nTotal Journal Entries: {_entries.Count}");
    }
}