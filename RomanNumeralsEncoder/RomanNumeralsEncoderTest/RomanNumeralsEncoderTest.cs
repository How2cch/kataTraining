using RomanNumeralsEncoder;

namespace RomanNumeralsEncoderTest;

public class Tests
{
    [TestCase(1, "I")]
    [TestCase(2, "II")]
    [TestCase(4, "IV")]
    [TestCase(500, "D")]
    [TestCase(1000, "M")]
    [TestCase(1954, "MCMLIV")]
    [TestCase(1990, "MCMXC")]
    [TestCase(2008, "MMVIII")]
    [TestCase(2014, "MMXIV")]
    public void RomanNumeralsEncoderTests(int value, string expected)
    {
        Assert.AreEqual(expected, Kata.Solution(value));
    }
}