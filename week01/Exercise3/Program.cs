using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        //int guessTimes = -1;
         //Console.Write("What is your guess? ");
            //int guessTrial = int.Parse(Console.ReadLine());

            int guess = -1;
            int guessNo = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            guessNo++;

            if (magicNumber > guess)
            {
                Console.WriteLine("Guess Higher." );
            }

            else if (magicNumber < guess)
            {
                Console.WriteLine("Guess Lower. ");
            }

            else
            {
                Console.WriteLine("You guessed Right.");
            }
            
            
        }    
        Console.WriteLine($"You Made {guessNo} guesses. ");
    }
}