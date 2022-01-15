using System.Collections.Generic;
using System.Text;
using System;

public class RomanConverter
{
    public static string ToRoman(int arabic)
    {
        var sb = new StringBuilder("");
        
        int reminder;
       
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
        }
        
        return sb.ToString();
    }  
    
    private AppendOrderOfMagnitude(orderOfMagnitude) 
    {
      var fifties = Math.DivRem(arabic, 50, out reminder); 
       sb.Append(symbols[orderOfMagnitude], fifties);
    }
    
    
    private Dictionary<int, char> symbols = new Dictionary<int, char>() 
    {
        {50, 'L'},
        {10, 'X'},
        {5, 'V'},
        {1, 'I'}
    }
           
    
   
}


