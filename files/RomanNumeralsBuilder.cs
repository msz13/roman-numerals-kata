internal class RomanNumeralsBuilder
{
    StringBuilder _sb;
    int _reminder;
    public RomanNumeralsBuilder(int arabic)
    {
        _reminder = arabic;
        _sb = new StringBuilder("");
    }
}