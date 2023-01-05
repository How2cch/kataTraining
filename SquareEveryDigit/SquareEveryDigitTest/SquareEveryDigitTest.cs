using SquareEveryDigit;

namespace SquareEveryDigitTest;

[TestFixture]
public class KataTest
{
    [Test]
    public void SquareDigitsTest()
    {
        Assert.That(Kata.SquareDigits(9119), Is.EqualTo(811181));
        Assert.That(Kata.SquareDigits(0), Is.EqualTo(0));
        Assert.That(Kata.SquareDigits(1121), Is.EqualTo(1141));
        Assert.That(Kata.SquareDigits(1101), Is.EqualTo(1101));
        Assert.That(Kata.SquareDigits(0090), Is.EqualTo(00810));
    }
}