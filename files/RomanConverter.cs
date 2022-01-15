using System.Collections.Generic;
using System.Text;

public class RomanConverter
{
    public static string ToRoman(int arabic)
    {
        var sb = new StringBuilder("");
        var isFive = arabic/5;
        var isTen = arabic/10;
            
        if(isTen == 10) {
           sb.Append('X',1);        
        } else
        if(isFive == 1 ) 
        {
            sb.Append('V', 1);
        } else 
        {
           sb.Append('I', arabic);
        }
        
        return sb.ToString();
    }          
           
    
    private static Dictionary<int,char> symbols = new Dictionary<int, char>() {
        {1, 'I'},
        {5, 'V'}, 
    };
}
