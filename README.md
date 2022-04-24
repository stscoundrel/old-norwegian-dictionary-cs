# Old Norwegian Dictionary

Old Norwegian/Norse Dictionary for C#. The dictionary consists of 40 000+ Old Norse words with Norwegian translations.

Based on "Dictionary of the Old Norwegian Language".

### Install

```
dotnet add package OldNorwegianDictionary
```

### Usage


```csharp
using OldNorwegianDictionary;

// Get all dictionary entries.
var dictionary = new Dictionary();
var result = dictionary.GetEntries();
Console.WriteLine(result.Count); // 42 021 entries.

// Individual entry contains headword, definition and part of speech.
DictionaryEntry entry = result[42000];
Console.WriteLine(entry.Headword); // þyrnir
Console.WriteLine(entry.PartOfSpeech); // m
Console.WriteLine(entry.Definition); // þyrnir, m. Tjørn, Tornebusk. [...] etc.

// Entries contain couple of helper methods.
DictionaryEntry entry2 = result[0];

// Part of speech does not exist in all entries.
Console.WriteLine(entry2.HasPartOfSpeech()); // false

// ToString is overwritten for generic presentation.
Console.WriteLine(entry2.ToString()); // [HEADWORD] - [DEFINITION]

```

### About "Dictionary of the Old Norwegian Language"

_"Ordbog over det gamle norske Sprog"_ dictionary was published in late 1800s by Johan Fritzner. Its is the largest Old Norse to Norwegian dictionary, containing over 40 000 word definitions. While the original dictionary is called dictionary of "old norwegian", it is practically a dictionary of western Old Norse. Technically "Old Norwegian" would be a later stage in the language.
