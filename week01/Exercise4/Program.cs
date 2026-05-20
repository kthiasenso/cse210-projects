using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        

        int userInput = 1;
        int total = 0;
        int larg_num = 0;
            

        do
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());
            if (userInput != 0)
            {
                numbers.Add(userInput);
                total += userInput;
                if (userInput > larg_num)
                {
                    larg_num = userInput;
                }
            }
                
        } while (userInput != 0);

            
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        float average = ((float)total) / numbers.Count;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {larg_num}");

            
    }
}