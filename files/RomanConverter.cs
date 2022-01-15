using System.Collections.Generic;

public class RomanConverter
{
    public static string ToRoman(int number)
    {
        return new string(symbols[number]);
    }
    
    private static Dictionary<int,string> symbols = new Dictionary<int, string>() {
        {1, "I"},        
    };
}
