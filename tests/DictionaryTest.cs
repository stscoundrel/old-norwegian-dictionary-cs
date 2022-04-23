using Xunit;
using System;
using OldNorwegianDictionary;

namespace OldNorwegianDictionaryTest;

public class DictionaryTest
{
    [Fact]
    public void DictionaryHasCorrectAmountOfEntriesTest()
    {
        var dictionary = new Dictionary();
        var result = dictionary.GetEntries();

        Assert.Equal(42021, result.Count);
    }

    [Fact]
    public void DictionaryHasExpectedContentTest()
    {
        var dictionary = new Dictionary();
        var result = dictionary.GetEntries();

        Assert.Equal("-æri", result[0].Headword);
        Assert.Equal("uten ordklasse", result[0].PartOfSpeech);
        Assert.Equal("-æri (af ár dvs. Aar) i hallæri.", result[0].Definition);

        Assert.Equal("fri", result[10000].Headword);
        Assert.Equal("m", result[10000].PartOfSpeech);
        Assert.Equal("fri, m. = friðill. Hým. 9.", result[10000].Definition);

        Assert.Equal("náðuliga", result[25000].Headword);
        Assert.Equal("adv", result[25000].PartOfSpeech);
        Assert.Equal("náðuliga, adv.  1)  i Stilhed, ubemærket; hann bauð at hafa Hánef þar á launþar til, er skip kemr n. at, svá athonum mætti útan koma Vem. 591; B.biskup biðr nú því öruggari til guðsaf öllu hjarta, sem hann má þat náð-uligar ok leyniligar gera fyrir mönn-um Mar. 116911 fg; biðjandi því meðmeira athuga, sem hann mátti leyni-ligar ok auðveldligar (&vl náðuligar)Mar. 83710. 34.  2)  naadigen; biðjom vér,at þér takir þessum várum erendumbetr ok náðuligar, en vér erum verðirDN. VII, 19013.", result[25000].Definition);

        Assert.Equal("þyrnir", result[42000].Headword);
        Assert.Equal("m", result[42000].PartOfSpeech);
        Assert.Equal("þyrnir, m. Tjørn, Tornebusk. Stj. 39611;Hom. 10218; Post. 75034; Klm. 54615;Mar. 3378. 10351.", result[42000].Definition);
    }
}