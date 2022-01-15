using System.Collections.Generic;
using System.Text;

public class RomanConverter
{
    public static string ToRoman(int arabic)
    {
        return new StringBuilder().Insert(0, symbols[1], arabic).ToString();
    }
    
    private static Dictionary<int,string> symbols = new Dictionary<int, string>() {
        {1, "I"},
        {5, "V"}, 
    };
}
