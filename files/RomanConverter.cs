using System.Collections.Generic;

public class RomanConverter
{
    public static string ToRoman(int arabic)
    {
        return new string(symbols[1], arabic);
    }
    
    private static Dictionary<int,string> symbols = new Dictionary<int, string>() {
        {1, "I"},        
    };
}
