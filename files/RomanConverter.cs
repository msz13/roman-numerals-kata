using System.Collections.Generic;
using System.Text;
using System;

public class RomanConverter
{
        
    public static string ToRoman(int arabic)
    {
                            
                
        
       return new RomanNumeralBuilder(arabic).GetResult();
        
      /* 
       reminder = appendOrderOfMagnitude(sb, reminder, 50);
       reminder = appendOrderOfMagnitude(sb, reminder, 10);
       reminder = appendOrderOfMagnitude(sb, reminder, 5);
       reminder = appendUnitsLessThanFive(sb, reminder);
       //reminder = appendOrderOfMagnitude(sb, reminder, 1);            
            
         var tens = Math.DivRem(reminder, 10, out reminder);
        var fives = Math.DivRem(reminder, 5, out reminder); 
                         
        sb.Append('L', fifties);
        sb.Append('X',tens);            
        sb.Append('V', fives);
      
          if (reminder == 4 ) 
        {
          sb.Append('I', 1);
          sb.Append('V', 1);
        } else 
        {
        sb.Append('I', reminder);    
        } */
        
       // return sb.ToString();
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
    
    
    private class RomanNumeralsBuilder
{
    StringBuilder _sb;
    int _reminder;
    public RomanNumeralsBuilder(int arabic)
    {
        _reminder = arabic;
        _sb = new StringBuilder("");
    }
}
    
   
}


