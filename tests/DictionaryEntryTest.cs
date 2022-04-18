using Xunit;
using OldNorwegianDictionary;

namespace OldNorwegianDictionaryTest;

public class DictionaryEntryTest
{
    [Fact]
    public void CanCreateInstance()
    {
        var entry = new DictionaryEntry("Skilja", "verb", "to separate, to divide");

        Assert.Equal("Skilja", entry.Headword);
        Assert.Equal("verb", entry.PartOfSpeech);
        Assert.Equal("to separate, to divide", entry.Definition);
        Assert.Equal(typeof(DictionaryEntry), entry.GetType());
    }

    [Fact]
    public void PartOfSpeechShortHandWorks()
    {
        var entry1 = new DictionaryEntry("Skilja", "verb", "to separate, to divide");
        var entry2 = new DictionaryEntry("Telja", "uten ordklasse", "to tell, to count");

        Assert.True(entry1.HasPartOfSpeech());
        Assert.False(entry2.HasPartOfSpeech());
    }

    [Fact]
    public void StringOutputWorks()
    {
        var entry1 = new DictionaryEntry("Skilja", "verb", "to separate, to divide");
        var entry2 = new DictionaryEntry("Telja", "uten ordklasse", "to tell, to count");

        Assert.Equal("Skilja - to separate, to divide", entry1.ToString());
        Assert.Equal("Telja - to tell, to count", entry2.ToString());
    }
}