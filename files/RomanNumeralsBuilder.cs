using System.Text;


public class RomanNumeralsBuilder
{
    StringBuilder _sb;
    int _reminder;
    public RomanNumeralsBuilder(int arabic)
    {
        _reminder = arabic;
        _sb = new StringBuilder("");
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
            return appendOrderOfMagnitude(sb, reminder, 1);
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
}
