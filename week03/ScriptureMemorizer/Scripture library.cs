public static class ScriptureLibrary
{
    private static readonly Random _random = new();
 
    private static readonly List<Scripture> _scriptures = new()
    {
        new Scripture
        (
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"
        ),
 
        new Scripture
        (
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all your heart and lean not on your own understanding in all your ways submit to him and he will make your paths straight"
        ),
 
        new Scripture
        (
            new Reference("Philippians", 4, 13),
            "I can do all things through Christ which strengtheneth me"
        ),
 
        new Scripture
        (
            new Reference("Joshua", 1, 9),
            "Have I not commanded you Be strong and courageous Do not be afraid do not be discouraged for the Lord your God will be with you wherever you go"
        ),
 
        new Scripture
        (
            new Reference("Psalms", 23, 1, 3),
            "The Lord is my shepherd I shall not want He makes me lie down in green pastures he leads me beside quiet waters he refreshes my soul"
        ),
    };
    
     public static Scripture GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}