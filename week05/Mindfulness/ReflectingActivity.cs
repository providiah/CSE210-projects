using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you helped someone.",
        "Think of a time when you overcame a challenge.",
        "Think of a time when you did something difficult."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?",
        "How can you apply this experience?"
    };

    public ReflectingActivity()
        : base(
              "Reflecting",
              "This activity helps you reflect on your strengths.")
    {
    }

    public void Run()
    {
        StartActivity();

        Random random = new Random();

        Console.WriteLine(
            "\nConsider the following prompt:\n");

        Console.WriteLine(
            $"--- {_prompts[random.Next(_prompts.Count)]} ---");

        Console.WriteLine(
            "\nWhen you have something in mind press Enter.");

        Console.ReadLine();

        DateTime endTime =
            DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(
                $"\n{_questions[random.Next(_questions.Count)]}");

            ShowSpinner(5);
        }

        EndActivity();
    }
}