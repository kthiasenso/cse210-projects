using System;

class Program
{
    static void Main(string[] args)
    {
        string response;
        
        do
        {
            Console.WriteLine("Hello and Welcome to the 'Guess the number'! ");
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);
            
            int guess = 0;
            while (guess != number)
            {
                Console.Write("What is your guess? ");
                string userInput = Console.ReadLine();
                guess = int.Parse(userInput);
                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You found it! ");
                }
            }
            
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } while (response == "yes");
        
    }
}