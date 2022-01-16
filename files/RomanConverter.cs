using System.Collections.Generic;
using System.Text;
using System;


public class RomanConverter
{
    StringBuilder _sb;
    int _reminder;
    
    public RomanConverter(int arabic)
    {
        _reminder = arabic;
        _sb = new StringBuilder("");
    }
    
    public static string ToRoman(int arabic)
    {
                            
              
       return new RomanConverter(arabic).AppendUnits().GetResult();
        
    }  
    
   public string GetResult()
    {
        return _sb.ToString();
    }
    
    public AppendUnits()
    {
         if(_reminder == 4) 
        {
            sb.Append(substractive[reminder]);
            return 0;
        } else
        {
            _reminder = appendOrderOfMagnitude(sb, reminder, 1);
        }
        
        return this;
    }
    
    private int appendOrderOfMagnitude(StringBuilder sb, int value, int orderOfMagnitude) 
    {
       int localReminder; 
       var result = Math.DivRem(value, orderOfMagnitude, out localReminder);    
      
       sb.Append(symbols[orderOfMagnitude], result);     
                    
       return  localReminder;
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
    



