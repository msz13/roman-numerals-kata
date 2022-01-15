using System.Collections.Generic;
using System.Text;
using System;

public class RomanConverter
{
    public static string ToRoman(int arabic)
    {
        var sb = new StringBuilder("");
        
        int reminder;
        var fifties = Math.DivRem(arabic, 50, out reminder); 
        var tens = Math.DivRem(reminder, 10, out reminder);
        var fives = Math.DivRem(reminder, 5, out reminder);      
                 
        sb.Append('X',tens);            
        sb.Append('V', fives);
        sb.Append('I', reminder);    
             
        return sb.ToString();
    }          
           
    
   
}


