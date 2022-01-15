using System.Collections.Generic;

public class RomanConverter
{
    public static string ToRoman(int number)
    {
        return new string(symbols[numbers]);
    }
    
    private static Dictionary<int,string> symbols = new Dictionary<int, string>() {
        {1, "I"},        
    };
}
