using NUnit.Framework;

[TestFixture]
public class HikerTest
{
    [TestCase(1, "I")]
    [TestCase(1, "II")]
    [TestCase(1, "III")]
    public void should_convert_arabic_to_Roman(int arabic, string roman)
    {
        // a simple example to start you off
        Assert.AreEqual(roman, RomanConverter.ToRoman(arabic));
    }
   
