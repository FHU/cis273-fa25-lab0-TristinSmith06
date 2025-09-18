namespace Prayer;

public record class ScriptureReference
{
    public string Book { get; set; }
    public int Chapter { get; set; }

    public int StartVerse { get; set; }

    public int EndVerse { get; set; }

    

    public override string ToString()
    {
        if (StartVerse == EndVerse)
        {
            return $"{Book} {Chapter}: {StartVerse}";
        }

        return $"{Book} {Chapter}: {StartVerse} - {EndVerse}";
    }

}