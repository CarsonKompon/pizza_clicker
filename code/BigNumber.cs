
using System;
using System.Collections.Generic;
using Sandbox;

namespace PizzaClicker;

public class BigNumber : IComparable
{
    public List<byte> Digits = new List<byte>();

    public string Value
    {
        get => ToString();
        set
        {
            Digits.Clear();
            for (int i = value.Length - 1; i >= 0; i--)
            {
                Digits.Add((byte)(value[i] - '0'));
            }
        }
    }

    public BigNumber()
    {
    }

    public BigNumber(string value)
    {
        for (int i = value.Length - 1; i >= 0; i--)
        {
            Digits.Add((byte)(value[i] - '0'));
        }
    }

    public BigNumber(ulong value)
    {
        while (value > 0)
        {
            Digits.Add((byte)(value % 10));
            value /= 10;
        }
    }

    // Addition that takes into account gaining and losing digits
    public static BigNumber operator +(BigNumber a, BigNumber b)
    {
        BigNumber result = new BigNumber(0);
        byte carry = 0;

        for (int i = 0; i < a.Digits.Count || i < b.Digits.Count || carry > 0; i++)
        {
            byte digit = carry;

            if (i < a.Digits.Count) digit += a.Digits[i];
            if (i < b.Digits.Count) digit += b.Digits[i];

            carry = (byte)(digit / 10);
            digit %= 10;

            result.Digits.Add(digit);
        }

        return result;
    }
    public static BigNumber operator +(BigNumber a, ulong b) => a + new BigNumber(b);

    // Subtraction
    public static BigNumber operator -(BigNumber a, BigNumber b)
    {
        BigNumber result = new BigNumber(0);
        byte carry = 0;

        for (int i = 0; i < a.Digits.Count || i < b.Digits.Count || carry > 0; i++)
        {
            byte digit = carry;

            if (i < a.Digits.Count) digit += a.Digits[i];
            if (i < b.Digits.Count) digit -= b.Digits[i];

            if (digit < 0)
            {
                digit += 10;
                carry = 9;
            }
            else
            {
                carry = 0;
            }

            result.Digits.Add(digit);
        }

        return result;
    }
    public static BigNumber operator -(BigNumber a, ulong b) => a - new BigNumber(b);

    // Multiplication
    public static BigNumber operator *(BigNumber a, BigNumber b)
    {
        BigNumber result = new BigNumber(0);

        for (int i = 0; i < a.Digits.Count; i++)
        {
            BigNumber temp = new BigNumber(0);
            byte carry = 0;

            for (int j = 0; j < b.Digits.Count || carry > 0; j++)
            {
                byte digit = carry;

                if (j < b.Digits.Count) digit += (byte)(a.Digits[i] * b.Digits[j]);

                carry = (byte)(digit / 10);
                digit %= 10;

                temp.Digits.Add(digit);
            }

            for (int j = 0; j < i; j++)
            {
                temp.Digits.Insert(0, 0);
            }

            result += temp;
        }

        return result;
    }
    public static BigNumber operator *(BigNumber a, ulong b) => a * new BigNumber(b);

    // Division
    public static BigNumber operator /(BigNumber a, BigNumber b)
    {
        BigNumber result = new BigNumber(0);
        BigNumber temp = new BigNumber(0);

        for (int i = a.Digits.Count - 1; i >= 0; i--)
        {
            temp.Digits.Insert(0, a.Digits[i]);

            byte x = 0;
            byte y = 10;

            while (x < y)
            {
                byte mid = (byte)((x + y) / 2);

                if ((b * (ulong)mid) > temp)
                {
                    y = mid;
                }
                else
                {
                    x = (byte)(mid + 1);
                }
            }

            result.Digits.Insert(0, (byte)(x - 1));
            temp -= b * (ulong)(x - 1);
        }

        return result;
    }
    public static BigNumber operator /(BigNumber a, ulong b) => a / new BigNumber(b);

    // Comparisons
    public static bool operator >(BigNumber a, BigNumber b)
    {
        if (a.Digits.Count > b.Digits.Count) return true;
        if (a.Digits.Count < b.Digits.Count) return false;

        for (int i = a.Digits.Count - 1; i >= 0; i--)
        {
            if (a.Digits[i] > b.Digits[i]) return true;
            if (a.Digits[i] < b.Digits[i]) return false;
        }

        return false;
    }
    public static bool operator >(BigNumber a, ulong b) => a > new BigNumber(b);

    public static bool operator <(BigNumber a, BigNumber b)
    {
        if (a.Digits.Count < b.Digits.Count) return true;
        if (a.Digits.Count > b.Digits.Count) return false;

        for (int i = a.Digits.Count - 1; i >= 0; i--)
        {
            if (a.Digits[i] < b.Digits[i]) return true;
            if (a.Digits[i] > b.Digits[i]) return false;
        }

        return false;
    }
    public static bool operator <(BigNumber a, ulong b) => a < new BigNumber(b);

    public static bool operator >=(BigNumber a, BigNumber b)
    {
        if (a.Digits.Count > b.Digits.Count) return true;
        if (a.Digits.Count < b.Digits.Count) return false;

        for (int i = a.Digits.Count - 1; i >= 0; i--)
        {
            if (a.Digits[i] > b.Digits[i]) return true;
            if (a.Digits[i] < b.Digits[i]) return false;
        }

        return true;
    }
    public static bool operator >=(BigNumber a, ulong b) => a >= new BigNumber(b);

    public static bool operator <=(BigNumber a, BigNumber b)
    {
        if (a.Digits.Count < b.Digits.Count) return true;
        if (a.Digits.Count > b.Digits.Count) return false;

        for (int i = a.Digits.Count - 1; i >= 0; i--)
        {
            if (a.Digits[i] < b.Digits[i]) return true;
            if (a.Digits[i] > b.Digits[i]) return false;
        }

        return true;
    }
    public static bool operator <=(BigNumber a, ulong b) => a <= new BigNumber(b);

    public static bool operator ==(BigNumber a, BigNumber b)
    {
        if (ReferenceEquals(a, b)) return true;
        if (a is null || b is null) return false;

        if (a.Digits.Count != b.Digits.Count) return false;

        for (int i = 0; i < a.Digits.Count; i++)
        {
            if (a.Digits[i] != b.Digits[i]) return false;
        }

        return true;
    }
    public static bool operator ==(BigNumber a, ulong b) => a == new BigNumber(b);

    public static bool operator !=(BigNumber a, BigNumber b)
    {
        if (ReferenceEquals(a, b)) return false;
        if (a is null || b is null) return true;

        if (a.Digits.Count != b.Digits.Count) return true;

        for (int i = 0; i < a.Digits.Count; i++)
        {
            if (a.Digits[i] != b.Digits[i]) return true;
        }

        return false;
    }
    public static bool operator !=(BigNumber a, ulong b) => a != new BigNumber(b);

    public override bool Equals(object obj)
    {
        if (obj == null) return false;

        BigNumber other = obj as BigNumber;
        if (other != null)
        {
            if (this.Digits.Count != other.Digits.Count) return false;

            for (int i = 0; i < this.Digits.Count; i++)
            {
                if (this.Digits[i] != other.Digits[i]) return false;
            }

            return true;
        }
        else
        {
            return false;
        }
    }

    // Conversions
    public static implicit operator BigNumber(ulong value) => new BigNumber(value);
    public static implicit operator BigNumber(long value) => new BigNumber((ulong)value);
    public static implicit operator BigNumber(int value) => new BigNumber((ulong)value);
    public static implicit operator BigNumber(short value) => new BigNumber((ulong)value);
    public static implicit operator BigNumber(sbyte value) => new BigNumber((ulong)value);

    // ToString
    public override string ToString()
    {
        if(Digits.Count == 0) return "0";

        string result = "";

        for (int i = Digits.Count - 1; i >= 0; i--)
        {
            result += Digits[i];
        }

        return result;
    }

    public string ToStringWithCommas()
    {
        string result = "";

        for (int i = Digits.Count - 1; i >= 0; i--)
        {
            result += Digits[i];

            if (i > 0 && i % 3 == 0) result += ",";
        }

        return result;
    }

    // Format abbreviations such as 1.3K, 2.4M, or 3.5B
    public string ToStringAbbreviated()
    {
        string result = "";

        if (Digits.Count <= 3)
        {
            result = ToString();
        }
        else
        {
            // Add decimal
            result = ToString().Substring(0, 1) + "." + ToString().Substring(1, 1);

            // Add suffix
            if (Digits.Count <= 6)
            {
                result += "K";
            }
            else if (Digits.Count <= 9)
            {
                result += "M";
            }
            else if (Digits.Count <= 12)
            {
                result += "B";
            }
            else if (Digits.Count <= 15)
            {
                result += "T";
            }
            else if (Digits.Count <= 18)
            {
                result += "Qa";
            }
            else if (Digits.Count <= 21)
            {
                result += "Qi";
            }
            else if (Digits.Count <= 24)
            {
                result += "Sx";
            }
            else if (Digits.Count <= 27)
            {
                result += "Sp";
            }
            else if (Digits.Count <= 30)
            {
                result += "Oc";
            }
            else if (Digits.Count <= 33)
            {
                result += "No";
            }
            else if (Digits.Count <= 36)
            {
                result += "Dc";
            }
            else if (Digits.Count <= 39)
            {
                result += "Ud";
            }
            else if (Digits.Count <= 42)
            {
                result += "Dd";
            }
            else if (Digits.Count <= 45)
            {
                result += "Td";
            }
            else if (Digits.Count <= 48)
            {
                result += "Qad";
            }
            else if (Digits.Count <= 51)
            {
                result += "Qid";
            }
            else if (Digits.Count <= 54)
            {
                result += "Sxd";
            }
            else if (Digits.Count <= 57)
            {
                result += "Spd";
            }
            else if (Digits.Count <= 60)
            {
                result += "Ocd";
            }
            else if (Digits.Count <= 63)
            {
                result += "Nod";
            }
            else if (Digits.Count <= 66)
            {
                result += "Vg";
            }
            else if (Digits.Count <= 69)
            {
                result += "Uvg";
            }
            else if (Digits.Count <= 72)
            {
                result += "Dvg";
            }
            else if (Digits.Count <= 75)
            {
                result += "Tvg";
            }
            else if (Digits.Count <= 78)
            {
                result += "Qavg";
            }
            else if (Digits.Count <= 81)
            {
                result += "Qivg";
            }
            else if (Digits.Count <= 84)
            {
                result += "Sxvg";
            }
            else if (Digits.Count <= 87)
            {
                result += "Spvg";
            }
            else if (Digits.Count <= 90)
            {
                result += "Ocvg";
            }
            else if (Digits.Count <= 93)
            {
                result += "Novg";
            }
            else if (Digits.Count <= 96)
            {
                result += "Tg";
            }
        }

        return result;
    }

    // format full words such as 1.3 thousand, 2.4 million, or 3.5 billion
    public string ToStringWithWords()
    {
        string result = "";

        if (Digits.Count <= 3)
        {
            result = ToString();
        }
        else if (Digits.Count <= 6)
        {
            result = ToString().Substring(0, 3) + " thousand";
        }
        else if (Digits.Count <= 9)
        {
            result = ToString().Substring(0, 3) + " million";
        }
        else if (Digits.Count <= 12)
        {
            result = ToString().Substring(0, 3) + " billion";
        }
        else if (Digits.Count <= 15)
        {
            result = ToString().Substring(0, 3) + " trillion";
        }
        else if (Digits.Count <= 18)
        {
            result = ToString().Substring(0, 3) + " quadrillion";
        }
        else if (Digits.Count <= 21)
        {
            result = ToString().Substring(0, 3) + " quintillion";
        }
        else if (Digits.Count <= 24)
        {
            result = ToString().Substring(0, 3) + " sextillion";
        }
        else if (Digits.Count <= 27)
        {
            result = ToString().Substring(0, 3) + " septillion";
        }
        else if (Digits.Count <= 30)
        {
            result = ToString().Substring(0, 3) + " octillion";
        }
        else if (Digits.Count <= 33)
        {
            result = ToString().Substring(0, 3) + " nonillion";
        }
        else if (Digits.Count <= 36)
        {
            result = ToString().Substring(0, 3) + " decillion";
        }
        else if (Digits.Count <= 39)
        {
            result = ToString().Substring(0, 3) + " undecillion";
        }
        else if (Digits.Count <= 42)
        {
            result = ToString().Substring(0, 3) + " duodecillion";
        }
        else if (Digits.Count <= 45)
        {
            result = ToString().Substring(0, 3) + " tredecillion";
        }
        else if (Digits.Count <= 48)
        {
            result = ToString().Substring(0, 3) + " quattuordecillion";
        }
        else if (Digits.Count <= 51)
        {
            result = ToString().Substring(0, 3) + " quindecillion";
        }
        else if (Digits.Count <= 54)
        {
            result = ToString().Substring(0, 3) + " sexdecillion";
        }
        else if (Digits.Count <= 57)
        {
            result = ToString().Substring(0, 3) + " septendecillion";
        }
        else if (Digits.Count <= 60)
        {
            result = ToString().Substring(0, 3) + " octodecillion";
        }
        else if (Digits.Count <= 63)
        {
            result = ToString().Substring(0, 3) + " novemdecillion";
        }
        else if (Digits.Count <= 66)
        {
            result = ToString().Substring(0, 3) + " vigintillion";
        }
        else if (Digits.Count <= 69)
        {
            result = ToString().Substring(0, 3) + " unvigintillion";
        }
        else if (Digits.Count <= 72)
        {
            result = ToString().Substring(0, 3) + " duovigintillion";
        }
        else if (Digits.Count <= 75)
        {
            result = ToString().Substring(0, 3) + " trevigintillion";
        }
        else if (Digits.Count <= 78)
        {
            result = ToString().Substring(0, 3) + " quattuorvigintillion";
        }
        else if (Digits.Count <= 81)
        {
            result = ToString().Substring(0, 3) + " quinvigintillion";
        }
        else if (Digits.Count <= 84)
        {
            result = ToString().Substring(0, 3) + " sexvigintillion";
        }
        else if (Digits.Count <= 87)
        {
            result = ToString().Substring(0, 3) + " septenvigintillion";
        }
        else if (Digits.Count <= 90)
        {
            result = ToString().Substring(0, 3) + " octovigintillion";
        }
        else if (Digits.Count <= 93)
        {
            result = ToString().Substring(0, 3) + " novemvigintillion";
        }
        else if (Digits.Count <= 96)
        {
            result = ToString().Substring(0, 3) + " trigintillion";
        }

        return result;
    }

    // Bytestream

    public void WriteToStream(ref ByteStream stream)
    {
        stream.Write((ulong)Digits.Count);
        for (int i = 0; i < Digits.Count; i++)
        {
            stream.Write(Digits[i]);
        }
    }

    public int GetByteSize()
    {
        return 8 + Digits.Count;
    }

    public static BigNumber ReadFromStream(ByteStream stream)
    {
        BigNumber result = new BigNumber(0);
        ulong count = stream.Read<ulong>();
        for (ulong i = 0; i < count; i++)
        {
            result.Digits.Add(stream.Read<byte>());
        }
        return result;
    } 

	// Hashing
	public override int GetHashCode()
	{
        int hash = 0;
        for (int i = 0; i < Digits.Count; i++)
        {
            hash += Digits[i];
        }
        return hash;
	}

    // IComparable
    public int CompareTo(object obj)
    {
        if (obj == null) return 1;

        BigNumber other = obj as BigNumber;
        if (other != null)
        {
            if (this > other) return 1;
            if (this < other) return -1;
            return 0;
        }
        else
        {
            throw new ArgumentException("Object is not a BigNumber");
        }
    }

}
