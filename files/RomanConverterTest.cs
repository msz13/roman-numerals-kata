using NUnit.Framework;

[TestFixture]
public class HikerTest
{
   [TestCase(1, "I")]      
   [TestCase(3, "III")]
   [TestCase(4, "IV")]
   [TestCase(5, "V")]   
   [TestCase(8, "VIII")]
   [TestCase(9, "IX")]
   [TestCase(10, "X")]   
   [TestCase(14, "XIV")]
   [TestCase(15, "XV")]
   [TestCase(19, "XIX")] 
   [TestCase(20, "XX")] 
   [TestCase(34, "XXXIV")]
   [TestCase(40, "XL")]
   [TestCase(44, "XLIV")]
   [TestCase(50, "L")]
   [TestCase(68, "LXVIII")]
   [TestCase(90, "XC")]
   [TestCase(91, "XCI")]     
   [TestCase(100, "C")]
   [TestCase(148, "CXLVIII")]
   [TestCase(108, "CVIII")]
   [TestCase(400, "CD")]
   [TestCase(411, "CDXI")] 
   [TestCase(500, "D")]
   [TestCase(534, "DXXXIV")]
   [TestCase(900, "CM")]
   [TestCase(990, "CMXC")]
   [TestCase(1000, "M")] 
   [TestCase(3999, "MMMCMXCIX")] 
   
    public void should_convert_arabic_to_Roman(int arabic, string roman)
    {
        // a simple example to start you off
        Assert.AreEqual(roman, RomanConverter.ToRoman(arabic));
    }
}
