using System;

// stretch 
// added a library of scripture to pick at random in it 
// added the ability to hide only the words that are still visible
// added a little header to the UI program

class Program
{
    static void Main(string[] args)
    {   
        // number of words hidden per Enter press
        const int WORDS_PER_STEP = 3; 
        
        // pick a random scripture from the library
        Scripture scripture = ScriptureLibrary.GetRandomScripture();
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("        SCRIPTURE  MEMORIZER          ");
            
            Console.WriteLine();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
        
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine();
                Console.WriteLine("Well done! All words are hidden.");
                break;
            }
            Console.WriteLine();
            Console.Write("Press [Enter] to hide more words, or type 'quit' to exit: ");
            string input = Console.ReadLine();
        
            if (input == "quit")
            {
                Console.WriteLine();
                Console.WriteLine("Goodbye!");
                break;
            }
        
            scripture.HideRandomWords(WORDS_PER_STEP);
        }
    }
}