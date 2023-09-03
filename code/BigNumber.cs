using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Sandbox;

public class BigNumber : IComparable
{
    private List<byte> digits = new();
    private bool isNegative = false;

    public BigNumber() {}
    public BigNumber(string number)
    {
        if (string.IsNullOrEmpty(number))
            throw new ArgumentNullException("Number string cannot be null or empty");
        
        isNegative = number.StartsWith("-");

        foreach (char c in number)
        {
            if (char.IsDigit(c))
            {
                digits.Add((byte)(c - '0'));
            }
        }
    }

    public BigNumber(int num) : this(num.ToString()) { }
    public BigNumber(long num) : this(num.ToString()) { }
    public BigNumber(ulong num) : this(num.ToString()) { }

    public string Value
    {
        get => ToString();
        set
        {
            BigNumber temp = new BigNumber(value);
            digits = temp.digits;
            isNegative = temp.isNegative;
        }
    }

    private static void Equalize(BigNumber a, BigNumber b)
    {
        while (a.digits.Count < b.digits.Count)
        {
            a.digits.Insert(0, 0);
        }

        while (b.digits.Count < a.digits.Count)
        {
            b.digits.Insert(0, 0);
        }
    }

    private void RemoveLeadingZeros()
    {
        while (digits.Count > 1 && digits[0] == 0)
        {
            digits.RemoveAt(0);
        }
    }

    public static BigNumber Add(BigNumber a, BigNumber b)
    {
        Equalize(a, b);
        
        if (a.isNegative && b.isNegative)
        {
            BigNumber result = AddPositive(a, b);
            result.isNegative = true;
            return result;
        }

        if (a.isNegative)
        {
            return Subtract(b, Negate(a));
        }

        if (b.isNegative)
        {
            return Subtract(a, Negate(b));
        }

        return AddPositive(a, b);
    }

    private static BigNumber AddPositive(BigNumber a, BigNumber b)
    {
        int carry = 0;
        List<byte> resultDigits = new List<byte>();
        for (int i = a.digits.Count - 1; i >= 0; i--)
        {
            int sum = a.digits[i] + b.digits[i] + carry;
            carry = sum / 10;
            resultDigits.Insert(0, (byte)(sum % 10));
        }

        if (carry > 0)
        {
            resultDigits.Insert(0, (byte)carry);
        }

        BigNumber result = new BigNumber();
        result.digits = resultDigits;
        result.RemoveLeadingZeros();
        
        return result;
    }

    public static BigNumber Subtract(BigNumber a, BigNumber b)
    {
        Equalize(a, b);

        if (a.isNegative && b.isNegative)
        {
            return Subtract(Negate(b), Negate(a));
        }

        if (a.isNegative)
        {
            BigNumber result = Add(Negate(a), b);
            result.isNegative = true;
            return result;
        }

        if (b.isNegative)
        {
            return Add(a, Negate(b));
        }

        if (a.CompareTo(b) < 0)
        {
            BigNumber result = SubtractPositive(b, a);
            result.isNegative = true;
            return result;
        }

        return SubtractPositive(a, b);
    }

    private static BigNumber SubtractPositive(BigNumber a, BigNumber b)
    {
        int borrow = 0;
        List<byte> resultDigits = new List<byte>();
        for (int i = a.digits.Count - 1; i >= 0; i--)
        {
            int diff = a.digits[i] - b.digits[i] - borrow;
            if (diff < 0)
            {
                diff += 10;
                borrow = 1;
            }
            else
            {
                borrow = 0;
            }
            resultDigits.Insert(0, (byte)diff);
        }

        BigNumber result = new BigNumber("0");
        result.digits = resultDigits;
        result.RemoveLeadingZeros();

        return result;
    }

    public static BigNumber Multiply(BigNumber a, BigNumber b)
    {
        BigNumber result = MultiplyPositive(a, b);
        result.isNegative = a.isNegative ^ b.isNegative;
        return result;
    }

    private static BigNumber MultiplyPositive(BigNumber a, BigNumber b)
    {
        BigNumber result = new BigNumber("0");

        for (int i = 0; i < a.digits.Count; i++)
        {
            List<byte> tempDigits = new List<byte>();
            int carry = 0;
            for (int j = b.digits.Count - 1; j >= 0; j--)
            {
                int prod = a.digits[i] * b.digits[j] + carry;
                carry = prod / 10;
                tempDigits.Insert(0, (byte)(prod % 10));
            }
            if (carry > 0)
            {
                tempDigits.Insert(0, (byte)carry);
            }
            for (int k = 0; k < a.digits.Count - 1 - i; k++)
            {
                tempDigits.Add(0);
            }

            BigNumber temp = new BigNumber("0");
            temp.digits = tempDigits;

            result = Add(result, temp);
        }

        return result;
    }

    public static BigNumber Divide(BigNumber a, BigNumber b, int precision)
    {
        BigNumber result = DividePositive(a, b, precision);
        result.isNegative = a.isNegative ^ b.isNegative;
        return result;
    }

    private static BigNumber DividePositive(BigNumber a, BigNumber b, int precision)
    {
        BigNumber result = new BigNumber("0");

        BigNumber remainder = new BigNumber("0");
        for (int i = 0; i < a.digits.Count; i++)
        {
            remainder.digits.Add(a.digits[i]);
            remainder.RemoveLeadingZeros();

            int count = 0;
            while (remainder.CompareTo(b) >= 0)
            {
                remainder = Subtract(remainder, b);
                count++;
            }

            result.digits.Add((byte)count);
        }

        return result;
    }

    private static BigNumber Negate(BigNumber a)
    {
        BigNumber result = new BigNumber(a.ToString());
        result.isNegative = !a.isNegative;
        return result;
    }

    public int CompareTo(BigNumber other)
    {
        if (isNegative && !other.isNegative) return -1;
        if (!isNegative && other.isNegative) return 1;

        int factor = isNegative ? -1 : 1;

        Equalize(this, other);

        for (int i = 0; i < digits.Count; i++)
        {
            if (digits[i] > other.digits[i])
            {
                return 1 * factor;
            }
            else if (digits[i] < other.digits[i])
            {
                return -1 * factor;
            }
        }

        return 0;
    }


    public int CompareTo(object obj)
    {
        if (obj == null) return 1;

        if (obj is BigNumber other)
        {
            return this.CompareTo(other);
        }
        else
        {
            throw new ArgumentException("Object is not a BigNumber");
        }
    }

    // Write to ByteStream
    public void WriteToStream(ref ByteStream stream)
    {
        stream.Write(Convert.ToByte(isNegative));
        stream.Write((int)digits.Count);
        foreach (byte digit in digits)
        {
            stream.Write(digit);
        }
    }

    public int GetByteSize()
    {
        return 5 + digits.Count;
    }

    public static BigNumber ReadFromStream(ref ByteStream stream)
    {
        BigNumber result = new BigNumber();
        result.isNegative = Convert.ToBoolean(stream.Read<byte>());
        int digitCount = stream.Read<int>();
        result.digits = new List<byte>();
        for (int i = 0; i < digitCount; i++)
        {
            result.digits.Add(stream.Read<byte>());
        }
        return result;
    }

    // HashCode
    public override int GetHashCode()
    {
        int hash = 17;
        hash = hash * 23 + isNegative.GetHashCode();
        hash = hash * 23 + digits.GetHashCode();
        return hash;
    }

    // Addition Operators
    public static BigNumber operator +(BigNumber a, BigNumber b) => Add(a, b);
    public static BigNumber operator +(BigNumber a, int b) => Add(a, new BigNumber(b));
    public static BigNumber operator +(BigNumber a, long b) => Add(a, new BigNumber(b));
    public static BigNumber operator +(BigNumber a, ulong b) => Add(a, new BigNumber(b));

    // Subtraction Operators
    public static BigNumber operator -(BigNumber a, BigNumber b) => Subtract(a, b);
    public static BigNumber operator -(BigNumber a, int b) => Subtract(a, new BigNumber(b));
    public static BigNumber operator -(BigNumber a, long b) => Subtract(a, new BigNumber(b));
    public static BigNumber operator -(BigNumber a, ulong b) => Subtract(a, new BigNumber(b));

    // Multiplication Operators
    public static BigNumber operator *(BigNumber a, BigNumber b) => Multiply(a, b);
    public static BigNumber operator *(BigNumber a, int b) => Multiply(a, new BigNumber(b));
    public static BigNumber operator *(BigNumber a, long b) => Multiply(a, new BigNumber(b));
    public static BigNumber operator *(BigNumber a, ulong b) => Multiply(a, new BigNumber(b));

    // Division Operators
    public static BigNumber operator /(BigNumber a, BigNumber b) => Divide(a, b, 10);
    public static BigNumber operator /(BigNumber a, int b) => Divide(a, new BigNumber(b), 10);
    public static BigNumber operator /(BigNumber a, long b) => Divide(a, new BigNumber(b), 10);
    public static BigNumber operator /(BigNumber a, ulong b) => Divide(a, new BigNumber(b), 10);

    // Equal Comparison Operators
    public static bool operator ==(BigNumber a, BigNumber b) => a.CompareTo(b) == 0;
    public static bool operator ==(BigNumber a, int b) => a.CompareTo(new BigNumber(b)) == 0;
    public static bool operator ==(BigNumber a, long b) => a.CompareTo(new BigNumber(b)) == 0;
    public static bool operator ==(BigNumber a, ulong b) => a.CompareTo(new BigNumber(b)) == 0;
   
    // Not Equal Comparison Operators
    public static bool operator !=(BigNumber a, BigNumber b) => a.CompareTo(b) != 0;
    public static bool operator !=(BigNumber a, int b) => a.CompareTo(new BigNumber(b)) != 0;
    public static bool operator !=(BigNumber a, long b) => a.CompareTo(new BigNumber(b)) != 0;
    public static bool operator !=(BigNumber a, ulong b) => a.CompareTo(new BigNumber(b)) != 0;
    
    // Less Than Comparison Operators
    public static bool operator <(BigNumber a, BigNumber b) => a.CompareTo(b) < 0;
    public static bool operator <(BigNumber a, int b) => a.CompareTo(new BigNumber(b)) > 0;
    public static bool operator <(BigNumber a, long b) => a.CompareTo(new BigNumber(b)) > 0;
    public static bool operator <(BigNumber a, ulong b) => a.CompareTo(new BigNumber(b)) > 0;
    
    // Greater Than Comparison Operators
    public static bool operator >(BigNumber a, BigNumber b) => a.CompareTo(b) > 0;
    public static bool operator >(BigNumber a, int b) => a.CompareTo(new BigNumber(b)) < 0;
    public static bool operator >(BigNumber a, long b) => a.CompareTo(new BigNumber(b)) < 0;
    public static bool operator >(BigNumber a, ulong b) => a.CompareTo(new BigNumber(b)) < 0;
    
    // Less Than or Equal Comparison Operators
    public static bool operator <=(BigNumber a, BigNumber b) => a.CompareTo(b) <= 0;
    public static bool operator <=(BigNumber a, int b) => a.CompareTo(new BigNumber(b)) <= 0;
    public static bool operator <=(BigNumber a, long b) => a.CompareTo(new BigNumber(b)) <= 0;
    public static bool operator <=(BigNumber a, ulong b) => a.CompareTo(new BigNumber(b)) <= 0;

    // Greater Than or Equal Comparison Operators
    public static bool operator >=(BigNumber a, BigNumber b) => a.CompareTo(b) >= 0;
    public static bool operator >=(BigNumber a, int b) => a.CompareTo(new BigNumber(b)) >= 0;
    public static bool operator >=(BigNumber a, long b) => a.CompareTo(new BigNumber(b)) >= 0;
    public static bool operator >=(BigNumber a, ulong b) => a.CompareTo(new BigNumber(b)) >= 0;
    
    // Casting
    public static implicit operator BigNumber(int num) => new BigNumber(num);
    public static implicit operator BigNumber(long num) => new BigNumber(num);
    public static implicit operator BigNumber(ulong num) => new BigNumber(num);

    // To String
    public override string ToString()
    {
        RemoveLeadingZeros();

        StringBuilder sb = new StringBuilder();
        if (isNegative) sb.Append('-');

        foreach (var digit in digits)
        {
            sb.Append(digit);
        }
        return sb.ToString();
    }

    // To String with commas (such as 1,041 or 1,456,235)
    public string ToStringWithCommas()
    {
        RemoveLeadingZeros();

        StringBuilder sb = new StringBuilder();
        if(isNegative) sb.Append('-');
        
        for (int i = 0; i < digits.Count; i++)
        {
            if (i > 0 && (digits.Count - i) % 3 == 0)
            {
                sb.Append(',');
            }
            sb.Append(digits[i]);
        }
        return sb.ToString();
    }

    // To String with abbreviated suffix (such as 1.04K or 1.46M)
    public string ToStringAbbreviated(int decimalPlaces = 2, bool removeTrailingZeros = true)
    {
        RemoveLeadingZeros();

        // Return normal string if less than 1000
        if (digits.Count < 4)
        {
            return ToString();
        }
        else
        {            
            // Get the suffix
            string suffix = "";
            int index = (digits.Count - 1) / 3;
            switch(index)
            {
                case 1:
                    suffix = "K";
                    break;
                case 2:
                    suffix = "M";
                    break;
                case 3:
                    suffix = "B";
                    break;
                case 4:
                    suffix = "T";
                    break;
                case 5:
                    suffix = "Qa";
                    break;
                case 6:
                    suffix = "Qi";
                    break;
                case 7:
                    suffix = "Sx";
                    break;
                case 8:
                    suffix = "Sp";
                    break;
                case 9:
                    suffix = "Oc";
                    break;
                case 10:
                    suffix = "No";
                    break;
                case 11:
                    suffix = "De";
                    break;
                case 12:
                    suffix = "Ud";
                    break;
                case 13:
                    suffix = "Dd";
                    break;
                case 14:
                    suffix = "Td";
                    break;
                case 15:
                    suffix = "Qad";
                    break;
                case 16:
                    suffix = "Qid";
                    break;
                case 17:
                    suffix = "Sxd";
                    break;
                case 18:
                    suffix = "Spd";
                    break;
                case 19:
                    suffix = "Ocd";
                    break;
                case 20:
                    suffix = "Nod";
                    break;
                case 21:
                    suffix = "Vg";
                    break;
                case 22:
                    suffix = "Uvg";
                    break;
                case 23:
                    suffix = "Dvg";
                    break;
                case 24:
                    suffix = "Tvg";
                    break;
                case 25:
                    suffix = "Qavg";
                    break;
                case 26:
                    suffix = "Qivg";
                    break;
                case 27:
                    suffix = "Sxvg";
                    break;
                case 28:
                    suffix = "Spvg";
                    break;
                case 29:
                    suffix = "Ocvg";
                    break;
                case 30:
                    suffix = "Novg";
                    break;
                case 31:
                    suffix = "Tg";
                    break;
                case 32:
                    suffix = "Utg";
                    break;
                case 33:
                    suffix = "Dtg";
                    break;
                case 34:
                    suffix = "Ttg";
                    break;
                case 35:
                    suffix = "Qatg";
                    break;
                case 36:
                    suffix = "Qitg";
                    break;
                case 37:
                    suffix = "Sxtg";
                    break;
                case 38:
                    suffix = "Sptg";
                    break;
                case 39:
                    suffix = "Octg";
                    break;
                case 40:
                    suffix = "Notg";
                    break;
            }

            // Get the string
            string prefix = (isNegative ? "-" : "");
            return prefix + ConstructAbbreviatedString(digits.Count, 3, decimalPlaces, removeTrailingZeros) + suffix;
        }
    }

    // To String With Words (such as 1.04 thousand or 1.46 million)
    public string ToStringWithWords(bool removeTrailingZeros = true)
    {
        RemoveLeadingZeros();
            
        // Return normal string if less than 1000
        if (digits.Count < 4)
        {
            return ToString();
        }
        else
        {
            // Get the suffix
            string suffix = "";
            int index = (digits.Count - 1) / 3;
            switch(index)
            {
                case 1:
                    suffix = "thousand";
                    break;
                case 2:
                    suffix = "million";
                    break;
                case 3:
                    suffix = "billion";
                    break;
                case 4:
                    suffix = "trillion";
                    break;
                case 5:
                    suffix = "quadrillion";
                    break;
                case 6:
                    suffix = "quintillion";
                    break;
                case 7:
                    suffix = "sextillion";
                    break;
                case 8:
                    suffix = "septillion";
                    break;
                case 9:
                    suffix = "octillion";
                    break;
                case 10:
                    suffix = "nonillion";
                    break;
                case 11:
                    suffix = "decillion";
                    break;
                case 12:
                    suffix = "undecillion";
                    break;
                case 13:
                    suffix = "duodecillion";
                    break;
                case 14:
                    suffix = "tredecillion";
                    break;
                case 15:
                    suffix = "quattuordecillion";
                    break;
                case 16:
                    suffix = "quindecillion";
                    break;
                case 17:
                    suffix = "sexdecillion";
                    break;
                case 18:
                    suffix = "septendecillion";
                    break;
                case 19:
                    suffix = "octodecillion";
                    break;
                case 20:
                    suffix = "novemdecillion";
                    break;
                case 21:
                    suffix = "vigintillion";
                    break;
                case 22:
                    suffix = "unvigintillion";
                    break;
                case 23:
                    suffix = "duovigintillion";
                    break;
                case 24:
                    suffix = "trevigintillion";
                    break;
                case 25:
                    suffix = "quattuorvigintillion";
                    break;
                case 26:
                    suffix = "quinvigintillion";
                    break;
                case 27:
                    suffix = "sexvigintillion";
                    break;
                case 28:
                    suffix = "septenvigintillion";
                    break;
                case 29:
                    suffix = "octovigintillion";
                    break;
                case 30:
                    suffix = "novemvigintillion";
                    break;
                case 31:
                    suffix = "trigintillion";
                    break;
                case 32:
                    suffix = "untrigintillion";
                    break;
                case 33:
                    suffix = "duotrigintillion";
                    break;
                case 34:
                    suffix = "tretrigintillion";
                    break;
                case 35:
                    suffix = "quattuortrigintillion";
                    break;
                case 36:
                    suffix = "quintrigintillion";
                    break;
                case 37:
                    suffix = "sextrigintillion";
                    break;
                case 38:
                    suffix = "septentrigintillion";
                    break;
                case 39:
                    suffix = "octotrigintillion";
                    break;
                case 40:
                    suffix = "novemtrigintillion";
                    break;
                case 41:
                    suffix = "quadragintillion";
                    break;
                case 42:
                    suffix = "unquadragintillion";
                    break;
                case 43:
                    suffix = "duoquadragintillion";
                    break;
                case 44:
                    suffix = "trequadragintillion";
                    break;
                case 45:
                    suffix = "quattuorquadragintillion";
                    break;
                case 46:
                    suffix = "quinquadragintillion";
                    break;
                case 47:
                    suffix = "sexquadragintillion";
                    break;
                case 48:
                    suffix = "septenquadragintillion";
                    break;
                case 49:
                    suffix = "octoquadragintillion";
                    break;
                case 50:
                    suffix = "novemquadragintillion";
                    break;
            }

            // Get the string
            string prefix = (isNegative ? "-" : "");
            return prefix + ConstructAbbreviatedString(digits.Count, 3, 2, removeTrailingZeros) + " " + suffix;
        }
    }      

    private string ConstructAbbreviatedString(int integerPartLength, int offset, int decimalPlaces, bool removeTrailingZeros = true)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < integerPartLength - offset + decimalPlaces; i++)
        {
            if (i == integerPartLength - offset)
            {
                sb.Append('.');
            }

            if (i < digits.Count)
            {
                sb.Append(digits[i]);
            }
            else
            {
                sb.Append('0');
            }
        }

        string result = sb.ToString();

        // Remove trailing zeros
        if(removeTrailingZeros)
        {
            if (result.Contains("."))
            {
                result = result.TrimEnd('0');
                if (result.EndsWith("."))
                {
                    result = result.TrimEnd('.');
                }
            }
        }

        return result;
    }
}
