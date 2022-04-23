namespace OldNorwegianDictionary;

using System.Reflection;

public class ResourceReader
{
    
    private const string DictionaryPath = "OldNorwegianDictionary.resources.dictionary.json";

    public static string ReadEntries()
    {
        var assembly = Assembly.GetExecutingAssembly();

        using (Stream stream = assembly.GetManifestResourceStream(DictionaryPath))
        using (StreamReader reader = new StreamReader(stream))
        {
            return reader.ReadToEnd();
        }
        
    }  
}