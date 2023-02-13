using System.Numerics;
using PerimeterOfSquares;

namespace PerimeterOfSquaresTest;

public class Tests
{
    [Test]
    public void PerimeterOfSquaresTest1() {
        Assert.AreEqual(new BigInteger(80), Kata.Soulution(new BigInteger(5)));
        Assert.AreEqual(new BigInteger(216), Kata.Soulution(new BigInteger(7)));
    }
    [Test]
    public void PerimeterOfSquaresTest2() {
        Assert.AreEqual(new BigInteger(80), Kata.Soulution2(new BigInteger(5)));
        Assert.AreEqual(new BigInteger(216), Kata.Soulution2(new BigInteger(7)));
    }
}