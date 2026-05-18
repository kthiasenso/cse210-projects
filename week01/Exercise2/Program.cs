using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is you grade? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";   
        }

        else if (grade >= 70)
        {
            letter = "C"; 
        }

        else if (grade >= 60)
        {
            letter = "D"; 
        }
        
        else
        {
            letter = "F"; 
        }

        Console.WriteLine($"With a grade of {grade} you have an {letter}");
        
        if (grade >= 70)
        {
            Console.WriteLine("Congratulation you passed the course! ");
        }
        else
        {
             Console.WriteLine("Better luck next time, study hard and you'll be able to do it. ");
        }
    }
}