using System.Collections.Generic;
using System.Text;

public class RomanConverter
{
    public static string ToRoman(int arabic)
    {
        var sb = new StringBuilder("");
        var isFive = arabic/5;
            
        if(isFive == 1 ) 
        {
            sb.Append('V, 1);
        } else 
        {
           sb.Append('I', arabic);
        }
        
        return sb.ToString();
    }          
           
    
    private static Dictionary<int,string> symbols = new Dictionary<int, string>() {
        {1, 'I'},
        {5, 'V'}, 
    };
}
