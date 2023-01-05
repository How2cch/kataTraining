using VowelCount;

namespace VowelCountTest;

[TestFixture]
public class KataTests
{
    [Test]
    public void TestCase1()
    {
        Assert.That(Kata.GetVowelCount("abracadabra"), Is.EqualTo(5), "Something Wrong!");
    }
    [Test]
    public void TestCase2()
    {
        Assert.That(Kata.GetVowelCount("aeiou"), Is.EqualTo(5), "Something Wrong!");
    }
    [Test]
    public void TestCase3()
    {
        Assert.That(Kata.GetVowelCount("123123agsdyuawgf"), Is.EqualTo(3), "Something Wrong!");
    }
    [Test]
    public void TestCase4()
    {
        Assert.That(Kata.GetVowelCount("1qz2wsx3dc4rfv5tgb6yhn7jm8k,9l.0p;/"), Is.EqualTo(0), "Something Wrong!");
    }
}