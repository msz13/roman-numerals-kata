using System.Collections.Generic;
using System.Text;
using System;

public class RomanConverter
{
    public static string ToRoman(int arabic)
    {
        var sb = new StringBuilder("");
        
        int reminder;
        var isTen = Math.DivRem(arabic, 10, out reminder);
        var isFive = Math.DivRem(reminder, 5, out reminder);
        
                 
       
        sb.Append('X',isTen);
                
        
      
            sb.Append('V', isFive);
            sb.Append('I', reminder);
     
           
  
        
        return sb.ToString();
    }          
           
    
    private static Dictionary<int,char> symbols = new Dictionary<int, char>() {
        {1, 'I'},
        {5, 'V'}, 
    };
}


