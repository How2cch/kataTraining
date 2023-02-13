using ValidBraces;

namespace ValidBracesTest;

public class Tests
{
    [Test]
    public void TestSoulution1() {
        Assert.AreEqual(true, Kata.Soulution( "()" ));
        Assert.AreEqual(true, Kata.Soulution("(){}[]"));
        Assert.AreEqual(true, Kata.Soulution("([{}])"));
        Assert.AreEqual(true, Kata.Soulution("([{({{{}}})}])"));
        Assert.AreEqual(false, Kata.Soulution("(}"));
        Assert.AreEqual(false, Kata.Soulution("[(])"));
        Assert.AreEqual(false, Kata.Soulution("[({})](]"));
    }
    [Test]
    public void TestSoulution2() {
        Assert.AreEqual(true, Kata.Soulution2( "()" ));
        Assert.AreEqual(true, Kata.Soulution2("(){}[]"));
        Assert.AreEqual(true, Kata.Soulution2("([{}])"));
        Assert.AreEqual(true, Kata.Soulution2("([{({{{}}})}])"));
        Assert.AreEqual(false, Kata.Soulution2("(}"));
        Assert.AreEqual(false, Kata.Soulution2("[(])"));
        Assert.AreEqual(false, Kata.Soulution2("[({})](]"));
    }
    [Test]
    public void TestSoulution3() {
        Assert.AreEqual(true, Kata.Soulution3( "()" ));
        Assert.AreEqual(true, Kata.Soulution3("(){}[]"));
        Assert.AreEqual(true, Kata.Soulution3("([{}])"));
        Assert.AreEqual(true, Kata.Soulution3("([{({{{}}})}])"));
        Assert.AreEqual(false, Kata.Soulution3("(}"));
        Assert.AreEqual(false, Kata.Soulution3("[(])"));
        Assert.AreEqual(false, Kata.Soulution3("[({})](]"));
    }
}

