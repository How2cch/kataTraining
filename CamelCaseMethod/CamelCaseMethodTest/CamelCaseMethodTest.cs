using CamelCaseMethod;

namespace CamelCaseMethodTest;

public class Tests
{
   [Test]
    public void CamelCaseMethodTests()
    {
        Assert.AreEqual("TestCase", "test case".CamelCase());
        Assert.AreEqual("CamelCaseMethod", "camel case method".CamelCase());
        Assert.AreEqual("SayHello", "say hello".CamelCase());
        Assert.AreEqual("CamelCaseWord", " camel case word".CamelCase());
        Assert.AreEqual("", "".CamelCase());
    }
}