using System.Collections.Generic;

public class RomanConverter
{
    public static string ToRoman(int number)
    {
        return Map[number];
    }
    
    private static Dictionary<int,string> Map = new Dictionary<int, string>() {
        {1, "I"},
        {2, "II"},
        {3, "III"}
    };
}
