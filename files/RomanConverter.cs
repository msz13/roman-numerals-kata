using System.Collections.Generic;
using System.Text;
using System;

public class RomanConverter
{
    public static string ToRoman(int arabic)
    {
        var sb = new StringBuilder("");
        
        int fiveReminder;
        var isFive = Math.DivRem(arabic,5, out fiveReminder);
        var isTen = arabic/10;
        
            
        if(isTen == 1) {
           sb.Append('X',1);
           return sb.ToString();
        } 
        
        if(isFive == 1 ) 
        {
            sb.Append('V', 1);
            sb.Append('I', 0);
            return sb.ToString();
        }  
        {
           sb.Append('I', arabic);
           return sb.ToString();
        }
        
        
    }          
           
    
    private static Dictionary<int,char> symbols = new Dictionary<int, char>() {
        {1, 'I'},
        {5, 'V'}, 
    };
}


