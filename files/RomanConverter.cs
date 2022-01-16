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
              
       return new RomanConverter(arabic).AppendTens().AppendUnits().GetResult();
        
    }  
    
   public string GetResult()
    {
        return _sb.ToString();
    }
    
    
    RomanConverter AppendUnits()
    {
         if(isSubstractive(4,9)) 
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
    
     RomanConverter AppendTens()
    {
        var result = Math.DivRem(_reminder, 10, out _reminder);    
         
         if(isSubstractive(9,4)) 
        {
            _sb.Append(substractive[result * 10]);          
             return this;
        }       
      
        
      if(result >= 5) 
       {
        _sb.Append(symbols[50]);
        _sb.Append(symbols[10], result - 5); 
       } else
       {
        _sb.Append(symbols[10], result);     
       }       
         
                             
       return this;
    }
    
    int appendOrderOfMagnitude(StringBuilder sb, int value, int orderOfMagnitude) 
    {
       int localReminder; 
       var result = Math.DivRem(value, orderOfMagnitude, out localReminder);    
      
       sb.Append(symbols[orderOfMagnitude], result);     
                    
       return  localReminder;
    }
    
    bool isSubstractive(int firstValue, int secondValue) 
    {
        return _reminder == firstValue || _reminder == secondValue;
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
        {9, "IX"},
        {40, "XL"},
        {90, "XC"}
    };   
       
    
   
}
    



