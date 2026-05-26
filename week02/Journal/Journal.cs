

using System.IO;
 
public class Journal
{
    private List<Entry> _entries = new List<Entry>();
 
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
 

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("");
            Console.WriteLine("The journal is empty. Start writing!");
            return;
        }

        Console.WriteLine("");
        Console.WriteLine("========== Journal Entries ==========");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
 
    
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToFileString());
            }
        }
 
        Console.WriteLine($"Journal saved to \"{file}\".");
    }
 
    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine($"Error: File \"{file}\" was not found.");
            return;
        }
 
        // clear to make it more readable
        _entries.Clear();
 
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            if (line != "")
            {
                Entry entry = Entry.FromFileString(line);
                _entries.Add(entry);
            }
        }
 
        Console.WriteLine($"Loaded {_entries.Count} entries from \"{file}\".");
    }
}