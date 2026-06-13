using System;
using System.Collections.Generic;

public class listingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who have you helped recently?",
        "What blessings have you received?",
        "Who are some of your personal heroes?"
    };

    public listingActivity()
        : base(
            "Listing",
            "This activity will help you reflect on the good things in your life by listing as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        StartActivity();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"\n--- {prompt} ---");

        Console.Write("\nYou may begin in: ");
        ShowCountdown(5);

        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");

            string response = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(response))
            {
                items.Add(response);
            }
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");

        EndActivity();
    }
}