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
              
       return new RomanConverter(arabic).AppendHoundreds().AppendTens().AppendUnits().GetResult();
        
    }  
    
   public string GetResult()
    {
        return _sb.ToString();
    }
    
    
    RomanConverter AppendUnits()
    {
         if(isSubstractive(_reminder)) 
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
         
         if(isSubstractive(result)) 
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
    
    RomanConverter AppendHoundreds()
    {
        return AppendOrderOfMagnitude(100);
    }
    
    RomanConverter AppendOrderOfMagnitude(int orderOfMagnitude) 
    {   
        var result = Math.DivRem(_reminder, orderOfMagnitude, out _reminder);    
         
        if(isSubstractive(result)) 
        {
            _sb.Append(substractive[result * orderOfMagnitude]);          
             return this;
        }      
      
        
     if(result >= 5) 
       {
        _sb.Append(symbols[5*orderOfMagnitude]);
        _sb.Append(symbols[orderOfMagnitude], result - 5); 
       } else
       {
        _sb.Append(symbols[orderOfMagnitude], result);    
       }       
         
                             
       return this;
    }
    
    bool isSubstractive(int number) 
    {
        return number == 4 || number == 9;
    }
    
  
    Dictionary<int, char> symbols = new Dictionary<int, char>() 
    {
        {500, 'D'},
        {100, 'C'},
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
        {90, "XC"},
        {400, "CD"},
        {900, "CM"},
    };   
       
    
   
}
    



