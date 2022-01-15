using NUnit.Framework;

[TestFixture]
public class HikerTest
{
    [TestCase(1, "I")]
    [TestCase(2, "II")]
    [TestCase(3, "III")]
    [TestCase(3, "III")]
    [TestCase(5, "V")]
    //[TestCase(10, "X")]
    //[TestCase(50, "L")]
    //[TestCase(100, "C")]
    //[TestCase(500, "D")]
    //[TestCase(1000, "M")]
    public void should_convert_arabic_to_Roman(int arabic, string roman)
    {
        // a simple example to start you off
        Assert.AreEqual(roman, RomanConverter.ToRoman(arabic));
    }
}
