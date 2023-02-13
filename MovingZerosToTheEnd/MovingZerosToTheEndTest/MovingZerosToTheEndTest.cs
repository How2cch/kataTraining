using MovingZerosToTheEnd;

namespace MovingZerosToTheEndTest;

public class Tests
{
    [Test]
    public void MovingZerosToTheEndTests()
    {
        Assert.AreEqual(new[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }, Kata.Soulution(new[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
        Assert.AreEqual(new[] { 1, 0, 0, 0, 0, 0 }, Kata.Soulution(new[] { 0, 0, 0, 0, 1, 0 }));
        Assert.AreEqual(new[] { 1, 2, 3, 6, 5, 4, 8 }, Kata.Soulution(new[] { 1, 2, 3, 6, 5, 4, 8 }));
    }
}