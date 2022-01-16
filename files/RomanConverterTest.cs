using NUnit.Framework;

[TestFixture]
public class HikerTest
{
   [TestCase(1, "I")]
   [TestCase(2, "II")]
   [TestCase(3, "III")]
   [TestCase(3, "III")]
   [TestCase(4, "IV")]
   [TestCase(5, "V")]
   [TestCase(6, "VI")]
   [TestCase(8, "VIII")]
   [TestCase(9, "IX")]
   [TestCase(10, "X")]
   [TestCase(11, "XI")]
   [TestCase(14, "XIV")]
   [TestCase(15, "XV")]   
   [TestCase(20, "XX")] 
   [TestCase(34, "XXXIV")]
   [TestCase(40, "XL")]
   [TestCase(44, "XLIV")]
   [TestCase(50, "L")]
   [TestCase(68, "LXVIII")]
   [TestCase(90, "XC")]
//    [TestCase(63, "LXIII")]    
    //[TestCase(100, "C")]
    //[TestCase(500, "D")]
    //[TestCase(1000, "M")] 
   
    public void should_convert_arabic_to_Roman(int arabic, string roman)
    {
        // a simple example to start you off
        Assert.AreEqual(roman, RomanConverter.ToRoman(arabic));
    }
}
