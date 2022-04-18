public readonly struct DictionaryEntry
{
    public string Headword { get; init; }
    public string PartOfSpeech { get; init; }
    public string Definition { get; init; }

    public override string ToString() => $"{Headword} - {Definition}";

    public DictionaryEntry(string headword, string partOfSpeech, string definition)
    {
        Headword = headword;
        PartOfSpeech = partOfSpeech;
        Definition = definition;
    }

    public bool HasPartOfSpeech() {
        return !PartOfSpeech.Equals("uten ordklasse");
    }
}