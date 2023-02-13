using SplitString;

namespace SplitStringTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SplitStringTests()
    {
        Assert.AreEqual(new string[] { "ab", "c_" }, Kata.Solution("abc"));
        Assert.AreEqual(new string[] { "ab", "cd", "ef" }, Kata.Solution("abcdef"));
    }
}