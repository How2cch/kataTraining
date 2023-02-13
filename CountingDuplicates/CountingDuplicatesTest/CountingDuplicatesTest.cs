using CountingDuplicates;

namespace CountingDuplicatesTest;

public class Tests
{
    [Test]
    public void CountingDuplicatesTests()
    {
        Assert.AreEqual(0, Kata.Soulution(""));
        Assert.AreEqual(0, Kata.Soulution("abcde"));
        Assert.AreEqual(2, Kata.Soulution("aabbcde"));
        Assert.AreEqual(2, Kata.Soulution("aabBcde"), "should ignore case");
        Assert.AreEqual(1, Kata.Soulution("Indivisibility"));
        Assert.AreEqual(2, Kata.Soulution("Indivisibilities"), "characters may not be adjacent");
    }
}