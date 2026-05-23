//learned about random, split and join commands

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private static readonly Random _random = new(); //stretch

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        //For God so loved the world, that he gave his only begotten Son, 
        //that whosoever believeth in him should not perish, but have everlasting life.
        _words = new List<Word>();
        foreach (string word in text.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        // stretch hide only words that are still visible
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                visibleWords.Add(word);
        }
 
        if (visibleWords.Count == 0)
            return;
 
        // never hide more words than the ones that are still visible
        int toHide = Math.Min(numberToHide, visibleWords.Count);
 
        for (int i = visibleWords.Count - 1; i > 0; i--)
        {
            int j = _random.Next(i + 1);
            Word temp = visibleWords[i];
            visibleWords[i] = visibleWords[j];
            visibleWords[j] = temp;
        }
 
        for (int i = 0; i < toHide; i++)
        {
            visibleWords[i].Hide();
        }
    }

    public string GetDisplayText()
    {
        string referenceLine = _reference.GetDisplayText();
 
        List<string> wordDisplays = new List<string>();
        foreach (Word word in _words)
        {
            wordDisplays.Add(word.GetDisplayText());
        }
 
        string verseLine = string.Join(" ", wordDisplays);
        return $"{referenceLine}\n{verseLine}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}