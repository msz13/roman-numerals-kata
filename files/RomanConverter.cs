using System.Collections.Generic;
using System.Text;
using System;
using RomanConverter;

namespace RomanConverter 
{
public class RomanConverter
{
        
    public static string ToRoman(int arabic)
    {
                            
              
       return new RomanNumeralsBuilder(arabic).GetResult();
        
    }  
    
    private static int appendOrderOfMagnitude(StringBuilder sb, int value, int orderOfMagnitude) 
    {
       int localReminder; 
       var result = Math.DivRem(value, orderOfMagnitude, out localReminder);    
      
       sb.Append(symbols[orderOfMagnitude], result);     
                    
       return  localReminder;
    }
    
    private static int appendUnitsLessThanFive(StringBuilder sb, int reminder)
    {
        if(reminder == 4) 
        {
            sb.Append(substractive[reminder]);
            return 0;
        } else
        {
            return appendOrderOfMagnitude(sb, reminder, 1);
        }
    }
    
    
  
    private static Dictionary<int, char> symbols = new Dictionary<int, char>() 
    {
        {50, 'L'},
        {10, 'X'},
        {5, 'V'},      
        {1, 'I'}
    };
    
    private static Dictionary<int, string> substractive = new Dictionary<int, string>() 
    {
        {4, "IV"},
        {9, "IX"}
    };   
       
    
   
}
    
}


