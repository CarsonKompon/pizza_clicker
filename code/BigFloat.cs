using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using Sandbox;

namespace PizzaClicker;

public class BigFloat : IComparable
{
    private List<int> Digits = new();
    private int DecimalPoint = 0;

    public string Value
    {
        get
        {
            string result = "";
            for (int i = Digits.Count - 1; i >= 0; i--)
            {
                if (i == DecimalPoint)
                {
                    result += ".";
                }
                result += Digits[i];
            }
            return result;
        }
        set
        {
            Digits.Clear();
            foreach (char c in value)
            {
                if (c == '.')
                {
                    DecimalPoint = Digits.Count;
                }
                else
                {
                    Digits.Add(c - '0');
                }
            }
        }
    }

    public BigFloat()
    {
    }

    public BigFloat(string value)
    {
        foreach (char c in value)
        {
            if (c == '.')
            {
                DecimalPoint = Digits.Count;
            }
            else
            {
                Digits.Add(c - '0');
            }
        }
    }

    public BigFloat(ulong value)
    {
        while (value > 0)
        {
            Digits.Add((int)(value % 10));
            value /= 10;
        }
    }

    public BigFloat(double value)
    {
        while (value > 0)
        {
            Digits.Add((int)(value % 10));
            value /= 10;
        }
    }

    // Addition
    public static BigFloat operator +(BigFloat a, BigFloat b)
    {
        BigFloat result = new("0");
        int carry = 0;
        int i = 0;
        while (i < a.Digits.Count || i < b.Digits.Count || carry > 0)
        {
            int sum = carry;
            if (i < a.Digits.Count)
            {
                sum += a.Digits[i];
            }
            if (i < b.Digits.Count)
            {
                sum += b.Digits[i];
            }
            result.Digits.Add(sum % 10);
            carry = sum / 10;
            i++;
        }
        return result;
    }
    public static BigFloat operator +(BigFloat a, ulong b) => a + new BigFloat(b);
    public static BigFloat operator +(BigFloat a, double b) => a + new BigFloat(b);

    // Subtraction
    public static BigFloat operator -(BigFloat a, BigFloat b)
    {
        BigFloat result = new("0");
        int carry = 0;
        int i = 0;
        while (i < a.Digits.Count || i < b.Digits.Count || carry > 0)
        {
            int diff = carry;
            if (i < a.Digits.Count)
            {
                diff += a.Digits[i];
            }
            if (i < b.Digits.Count)
            {
                diff -= b.Digits[i];
            }
            if (diff < 0)
            {
                diff += 10;
                carry = -1;
            }
            else
            {
                carry = 0;
            }
            result.Digits.Add(diff);
            i++;
        }
        return result;
    }
    public static BigFloat operator -(BigFloat a, ulong b) => a - new BigFloat(b);
    public static BigFloat operator -(BigFloat a, double b) => a - new BigFloat(b);

    // Multiplication
    public static BigFloat operator *(BigFloat a, BigFloat b)
    {
        BigFloat result = new("0");
        for (int i = 0; i < a.Digits.Count; i++)
        {
            BigFloat row = new("0");
            for (int j = 0; j < b.Digits.Count; j++)
            {
                row.Digits.Add(a.Digits[i] * b.Digits[j]);
            }
            row.Digits.Insert(0, 0);
            result += row;
        }
        return result;
    }
    public static BigFloat operator *(BigFloat a, ulong b) => a * new BigFloat(b);
    public static BigFloat operator *(BigFloat a, double b) => a * new BigFloat(b);

    // Division
    public static BigFloat operator /(BigFloat a, BigFloat b)
    {
        BigFloat result = new("0");
        BigFloat remainder = new("0");
        for (int i = a.Digits.Count - 1; i >= 0; i--)
        {
            remainder.Digits.Insert(0, a.Digits[i]);
            int x = 0;
            int y = 10;
            while (x < y)
            {
                int m = (x + y) / 2;
                BigFloat row = b * new BigFloat(m);
                if (row <= remainder)
                {
                    x = m + 1;
                }
                else
                {
                    y = m;
                }
            }
            x--;
            BigFloat row2 = b * new BigFloat(x);
            remainder -= row2;
            result.Digits.Insert(0, x);
        }
        return result;
    }
    public static BigFloat operator /(BigFloat a, ulong b) => a / new BigFloat(b);
    public static BigFloat operator /(BigFloat a, double b) => a / new BigFloat(b);

    // Comparisons
    public static bool operator <(BigFloat a, BigFloat b)
    {
        if (a.Digits.Count != b.Digits.Count)
        {
            return a.Digits.Count < b.Digits.Count;
        }
        for (int i = a.Digits.Count - 1; i >= 0; i--)
        {
            if (a.Digits[i] != b.Digits[i])
            {
                return a.Digits[i] < b.Digits[i];
            }
        }
        return false;
    }
    public static bool operator <(BigFloat a, ulong b) => a < new BigFloat(b);
    public static bool operator <(BigFloat a, double b) => a < new BigFloat(b);

    public static bool operator >(BigFloat a, BigFloat b)
    {
        if (a.Digits.Count != b.Digits.Count)
        {
            return a.Digits.Count > b.Digits.Count;
        }
        for (int i = a.Digits.Count - 1; i >= 0; i--)
        {
            if (a.Digits[i] != b.Digits[i])
            {
                return a.Digits[i] > b.Digits[i];
            }
        }
        return false;
    }
    public static bool operator >(BigFloat a, ulong b) => a > new BigFloat(b);
    public static bool operator >(BigFloat a, double b) => a > new BigFloat(b);

    public static bool operator <=(BigFloat a, BigFloat b)
    {
        if (a.Digits.Count != b.Digits.Count)
        {
            return a.Digits.Count < b.Digits.Count;
        }
        for (int i = a.Digits.Count - 1; i >= 0; i--)
        {
            if (a.Digits[i] != b.Digits[i])
            {
                return a.Digits[i] < b.Digits[i];
            }
        }
        return true;
    }
    public static bool operator <=(BigFloat a, ulong b) => a <= new BigFloat(b);
    public static bool operator <=(BigFloat a, double b) => a <= new BigFloat(b);

    public static bool operator >=(BigFloat a, BigFloat b)
    {
        if (a.Digits.Count != b.Digits.Count)
        {
            return a.Digits.Count > b.Digits.Count;
        }
        for (int i = a.Digits.Count - 1; i >= 0; i--)
        {
            if (a.Digits[i] != b.Digits[i])
            {
                return a.Digits[i] > b.Digits[i];
            }
        }
        return true;
    }
    public static bool operator >=(BigFloat a, ulong b) => a >= new BigFloat(b);
    public static bool operator >=(BigFloat a, double b) => a >= new BigFloat(b);

    public static bool operator ==(BigFloat a, BigFloat b)
    {
        if(ReferenceEquals(a, b)) return true;
        if (a is null || b is null) return false;

        if (a.Digits.Count != b.Digits.Count)
        {
            return false;
        }
        for (int i = a.Digits.Count - 1; i >= 0; i--)
        {
            if (a.Digits[i] != b.Digits[i])
            {
                return false;
            }
        }
        return true;
    }
    public static bool operator ==(BigFloat a, ulong b) => a == new BigFloat(b);
    public static bool operator ==(BigFloat a, double b) => a == new BigFloat(b);

    public static bool operator !=(BigFloat a, BigFloat b)
    {
        if (ReferenceEquals(a, b)) return false;
        if (a is null || b is null) return true;

        if (a.Digits.Count != b.Digits.Count)
        {
            return true;
        }
        for (int i = a.Digits.Count - 1; i >= 0; i--)
        {
            if (a.Digits[i] != b.Digits[i])
            {
                return true;
            }
        }
        return false;
    }
    public static bool operator !=(BigFloat a, ulong b) => a != new BigFloat(b);
    public static bool operator !=(BigFloat a, double b) => a != new BigFloat(b);

	public override bool Equals( object obj )
	{
        if ( obj == null )
            return false;

        if ( obj is BigFloat )
            return this == (BigFloat)obj;

        return false;
	}

	// Conversions
	public static implicit operator BigFloat(ulong value) => new(value);
    public static implicit operator BigFloat(double value) => new(value);
    public static implicit operator BigFloat(string value) => new(value);

    // ToString
    public override string ToString()
    {
        if(Digits.Count == 0) return "0";

        string result = "";
        for (int i = Digits.Count - 1; i >= 0; i--)
        {
            if (i == DecimalPoint)
            {
                result += ".";
            }
            result += Digits[i];
        }
        return result;
    }

    public string ToStringWithCommas()
    {
        string result = "";
        for (int i = Digits.Count - 1; i >= 0; i--)
        {
            if (i == DecimalPoint)
            {
                result += ".";
            }
            if (i != Digits.Count - 1 && (Digits.Count - i - 1) % 3 == 0)
            {
                result += ",";
            }
            result += Digits[i];
        }
        return result;
    }

    // Format appreviations such as 1.3K, 2.4M, or 3.5B
    public string ToStringAbbreviated()
    {
        if(Digits.Count - DecimalPoint <= 3)
        {
            return ToString();
        }
        else
        {
            int digits = Digits.Count - DecimalPoint;
            int index = (digits - 1) / 3;
            string result = "";
            for (int i = 0; i < 3; i++)
            {
                if (i == DecimalPoint)
                {
                    result += ".";
                }
                result += Digits[i];
            }
            result += " ";
            switch (index)
            {
                case 1:
                    result += "K";
                    break;
                case 2:
                    result += "M";
                    break;
                case 3:
                    result += "B";
                    break;
                case 4:
                    result += "T";
                    break;
                case 5:
                    result += "Qa";
                    break;
                case 6:
                    result += "Qi";
                    break;
                case 7:
                    result += "Sx";
                    break;
                case 8:
                    result += "Sp";
                    break;
                case 9:
                    result += "Oc";
                    break;
                case 10:
                    result += "No";
                    break;
                case 11:
                    result += "De";
                    break;
                case 12:
                    result += "Ud";
                    break;
                case 13:
                    result += "Dd";
                    break;
                case 14:
                    result += "Td";
                    break;
                case 15:
                    result += "Qad";
                    break;
                case 16:
                    result += "Qid";
                    break;
                case 17:
                    result += "Sxd";
                    break;
                case 18:
                    result += "Spd";
                    break;
                case 19:
                    result += "Ocd";
                    break;
                case 20:
                    result += "Nod";
                    break;
                case 21:
                    result += "Vg";
                    break;
                case 22:
                    result += "Uvg";
                    break;
                case 23:
                    result += "Dvg";
                    break;
                case 24:
                    result += "Tvg";
                    break;
                case 25:
                    result += "Qavg";
                    break;
                case 26:
                    result += "Qivg";
                    break;
                case 27:
                    result += "Sxvg";
                    break;
                case 28:
                    result += "Spvg";
                    break;
                case 29:
                    result += "Ocvg";
                    break;
                case 30:
                    result += "Novg";
                    break;
                case 31:
                    result += "Tg";
                    break;
                case 32:
                    result += "Utg";
                    break;
                case 33:
                    result += "Dtg";
                    break;
                case 34:
                    result += "Ttg";
                    break;
                case 35:
                    result += "Qatg";
                    break;
                case 36:
                    result += "Qitg";
                    break;
                case 37:
                    result += "Sxtg";
                    break;
                case 38:
                    result += "Sptg";
                    break;
                case 39:
                    result += "Octg";
                    break;
                case 40:
                    result += "Notg";
                    break;
            }
        }

        return "0";
    }

    // Bytestream
    public void WriteToStream(ref ByteStream stream)
    {
        stream.Write((int)Digits.Count);
        stream.Write((int)DecimalPoint);
        foreach (int digit in Digits)
        {
            stream.Write(digit);
        }
    }

    public int GetByteSize()
    {
        return 8 + Digits.Count * 4;
    }

    public static BigFloat ReadFromStream(ByteStream stream)
    {
        int count = stream.Read<int>();
        int decimalPoint = stream.Read<int>();
        BigFloat result = new("0");
        result.DecimalPoint = decimalPoint;
        for (int i = 0; i < count; i++)
        {
            result.Digits.Add(stream.Read<int>());
        }
        return result;
    }

    // Hashing
    public override int GetHashCode()
    {
        int hash = 17;
        foreach (int digit in Digits)
        {
            hash = hash * 23 + digit.GetHashCode();
        }
        return hash;
    }

    // IComparable
    public int CompareTo(object obj)
    {
        if (obj == null) return 1;

        BigFloat other = obj as BigFloat;
        if (other != null)
        {
            if (this < other) return -1;
            if (this > other) return 1;
            return 0;
        }
        else
        {
            throw new System.ArgumentException("Object is not a BigFloat");
        }
    }

}