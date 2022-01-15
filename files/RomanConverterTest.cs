using NUnit.Framework;

[TestFixture]
public class HikerTest
{
    [TestCase(1, "I")]
    [TestCase(1, "II")]
    [TestCase(1, "III")]
    public void should_convert_below_five()
    {
        // a simple example to start you off
        Assert.AreEqual("I", RomanConverter.ToRoman(1));
    }
    
    [Test]
    public void should_convert_three()
    {
        // a simple example to start you off
        Assert.AreEqual("III", RomanConverter.ToRoman(3));
    }
}
