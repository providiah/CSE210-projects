using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people you appreciate?",
        "What are your personal strengths?",
        "Who have you helped recently?",
        "What blessings have you received?"
    };

    public ListingActivity()
        : base(
              "Listing",
              "This activity helps you list positive things in your life.")
    {
    }

    public void Run()
    {
        StartActivity();

        Random random = new Random();

        Console.WriteLine(
            "\nList as many responses as you can to:");

        Console.WriteLine(
            $"\n--- {_prompts[random.Next(_prompts.Count)]} ---");

        Console.Write("\nYou may begin in: ");
        ShowCountdown(5);

        List<string> items = new List<string>();

        DateTime endTime =
            DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine(
            $"\nYou listed {items.Count} items!");

        EndActivity();
    }
}