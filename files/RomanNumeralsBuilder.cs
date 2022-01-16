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
}
