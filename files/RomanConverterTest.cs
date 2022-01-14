using NUnit.Framework;

[TestFixture]
public class HikerTest
{
    [Test]
    public void should_convert_below_five()
    {
        // a simple example to start you off
        Assert.AreEqual("I", RomanConverter.ToRoman(1));
    }
}
