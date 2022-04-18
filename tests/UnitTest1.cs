using Xunit;
using OldNorwegianDictionary;

namespace OldNorwegianDictionaryTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("Lorem ipsum", Class1.testMethod());
    }
}