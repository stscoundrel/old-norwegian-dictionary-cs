namespace OldNorwegianDictionary;

using System.Collections.Generic;
using System.Text.Json;
using System.Reflection;

public class Dictionary
{
    
    private List<DictionaryEntry> Entries;

    public Dictionary()
    {
        Entries = CreareEntries();
    }

    private List<DictionaryEntry> CreareEntries()
    {
        string jsonResult = ResourceReader.ReadEntries();
        var entryResult = JsonSerializer.Deserialize<List<DictionaryEntry>>(jsonResult);

        return entryResult;
        
    }

    public List<DictionaryEntry> GetEntries()
    {
        return Entries;
    }    
}