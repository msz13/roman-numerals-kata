using System.Collections.Generic;
using System.Text;
using System;


public class RomanConverter
{

    public static string ToRoman(int arabic)
    {
        if (arabic >= 4000 || arabic <= 0)
            throw new ArgumentOutOfRangeException("arabic", null, "Algorytm nie obsługuje licbz większych niż 3999 i mniejszych lub równych zero");

        return new RomanConverter(arabic)
            .AppendThousands()
            .AppendHoundreds()
            .AppendTens()
            .AppendUnits()
            .GetResult();
    }


    StringBuilder _sb;
    int _reminder;

    private RomanConverter(int arabic)
    {
        _reminder = arabic;
        _sb = new StringBuilder("");
    }



    public string GetResult()
    {
        return _sb.ToString();
    }


    RomanConverter AppendUnits()
    {
        return AppendOrderOfMagnitude(OrdersOfMagnitude.Units);
    }

    RomanConverter AppendTens()
    {
        return AppendOrderOfMagnitude(OrdersOfMagnitude.Tens);
    }

    RomanConverter AppendHoundreds()
    {
        return AppendOrderOfMagnitude(OrdersOfMagnitude.Houndreads);
    }
    RomanConverter AppendThousands()
    {
        return AppendOrderOfMagnitude(OrdersOfMagnitude.Thousands);
    }

    RomanConverter AppendOrderOfMagnitude(OrdersOfMagnitude orderOfMagnitude)
    {
        var _orderOfMagnitude = (int)orderOfMagnitude;
        
        var result = Math.DivRem(_reminder, _orderOfMagnitude, out _reminder);

        if (isSubstractive(result))
        {
            _sb.Append(substractive[result * _orderOfMagnitude]);
            return this;
        }

        if (result >= 5)
        {
            _sb.Append(symbols[5 * _orderOfMagnitude]);
            _sb.Append(symbols[_orderOfMagnitude], result - 5);
        }
        else
        {
            _sb.Append(symbols[_orderOfMagnitude], result);
        }

        return this;
    }

    bool isSubstractive(int number)
    {
        return number == 4 || number == 9;
    }

    enum OrdersOfMagnitude
    {
        Units = 1,
        Tens = 10,

        Houndreads = 100,

        Thousands = 1000

    }

    Dictionary<int, char> symbols = new Dictionary<int, char>()
    {
        {1000, 'M'},
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




