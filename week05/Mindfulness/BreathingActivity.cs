using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
              "Breathing",
              "This activity will help you relax by guiding your breathing.")
    {
    }

    public void Run()
    {
        StartActivity();

        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(4);

            Console.Write("\nBreathe out... ");
            ShowCountdown(6);

            elapsed += 10;
        }

        EndActivity();
    }
}