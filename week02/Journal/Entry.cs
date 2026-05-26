
//using private since learned about it last week
public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;
 
    
    public Entry(string date, string promptText, string entryText)
    {
        _date       = date;
        _promptText = promptText;
        _entryText  = entryText;
    }
 

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine("----------------------------");
    }
 
    // using "___" as a separator to put in file
    public string ToFileString()
    {
        return $"{_date}___{_promptText}___{_entryText}";
    }
 
    // switching back for display
    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split("___");
        return new Entry(parts[0], parts[1], parts[2]);
    }
}