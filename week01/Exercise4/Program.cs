using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int>numbers = new List<int>();
        int numberInput = -1;

        while (numberInput != 0)
        {
            //List<int>numbers = new List<int>();
            Console.Write("Enter a List of Numbers, type 0 when finsh. ");
            string userChoice = Console.ReadLine();
            numberInput = int.Parse(userChoice);

            if (numberInput != 0)
            {
                numbers.Add(numberInput);
            }
        }    
            
        
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }


        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        numbers.Sort();

        Console.WriteLine($"The Total is {total}.");

        float average = ((float) total) / numbers.Count;
        Console.WriteLine($"The average is {average}.");
        Console.WriteLine($"The max is {max}");

        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is {smallestPositive}");
        }

        Console.WriteLine("The sorted List is: ");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        
    }
}