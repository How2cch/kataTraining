using MakeTheDeadfishSwimTest;

namespace MakeTheDeadfishSwimTest;

public class Tests
{
  
    [Test]
    public void MakeTheDeadfishSwimTests()
    {
        Assert.AreEqual(new[] {8, 64}, Kata.Soulution("iiisdoso"));
        Assert.AreEqual(new[] {8, 64, 3600}, Kata.Soulution("iiisdosodddddiso"));
    }
}
