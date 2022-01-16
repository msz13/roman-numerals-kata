using System.Collections.Generic;
using System.Text;
using System;


public class RomanConverter
{
    StringBuilder _sb;
    int _reminder;
    
    private RomanConverter(int arabic)
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
    
    
    RomanConverter AppendUnits()
    {
         if(_reminder == 4 || _reminder == 9) 
        {
            _sb.Append(substractive[_reminder]);
            _reminder = 0;
             return this;
        } 
        
       int localReminder; 
       var result = Math.DivRem(_reminder, 5, out localReminder);  
        
       if(result == 1) 
       {
        _sb.Append(symbols[5]);
       }
        
       _sb.Append(symbols[1], localReminder);          
                       
       return this;
    }
    
    int appendOrderOfMagnitude(StringBuilder sb, int value, int orderOfMagnitude) 
    {
       int localReminder; 
       var result = Math.DivRem(value, orderOfMagnitude, out localReminder);    
      
       sb.Append(symbols[orderOfMagnitude], result);     
                    
       return  localReminder;
    }
    
    
    
  
    Dictionary<int, char> symbols = new Dictionary<int, char>() 
    {
        {50, 'L'},
        {10, 'X'},
        {5, 'V'},      
        {1, 'I'}
    };
    
    Dictionary<int, string> substractive = new Dictionary<int, string>() 
    {
        {4, "IV"},
        {9, "IX"}
    };   
       
    
   
}
    



