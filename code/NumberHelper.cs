using System;

public static class NumberHelper
{
    public static string Format(double value, int decimalPlaces = 2, bool removeTrailingZeros = true)
    {
        // Return normal string if no decimal value
        if(decimalPlaces == 0)
        {
            return value.ToString("F0");
        }
        else if(value - Math.Floor(value) == 0)
        {
            return value.ToString();
        }

        string result = value.ToString("F" + decimalPlaces);

        // Remove trailing zeros after decimal
        if(removeTrailingZeros)
        {
            int index = result.Length - 1;
            while(result[index] == '0')
            {
                index--;
            }
            if(result[index] == '.')
            {
                index--;
            }
            result = result.Substring(0, index + 1);
        }

        return result;
    }

    // To String with commas (such as 1,041 or 1,456,235)
    public static string ToStringWithCommas(double value)
    {
        string result = value.ToString("F0");
        int index = result.Length - 3;
        while(index > 0)
        {
            result = result.Insert(index, ",");
            index -= 3;
        }
        return result;
    }

    // To String with abbreviated suffix (such as 1.04K or 1.46M)
    public static string ToStringAbbreviated(double value, int decimalPlaces = 2, bool removeTrailingZeros = true)
    {
        // Return normal string if less than 1000
        if (value < 1000)
        {
            return Format(value, decimalPlaces, removeTrailingZeros);
        }
        else
        {
            var digitCount = value.ToString("F0").Length;
            // Get the suffix
            string suffix = "";
            int index = (digitCount - 1) / 3;
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
            return ConstructAbbreviatedString(value, decimalPlaces, removeTrailingZeros) + suffix;
        }
    }

    // To String With Words (such as 1.04 thousand or 1.46 million)
    public static string ToStringWithWords(double value, bool removeTrailingZeros = true)
    {            
        // Return normal string if less than 1000
        if (value < 1000)
        {
            return value.ToString();
        }
        else
        {
            var digitCount = value.ToString("F0").Length;
            // Get the suffix
            string suffix = "";
            int index = (digitCount - 1) / 3;
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
            string abbreviation = ConstructAbbreviatedString(value, 2, removeTrailingZeros);
            return abbreviation + " " + suffix;
        }
    }      

    private static string ConstructAbbreviatedString(double value, int decimalPlaces, bool removeTrailingZeros = true)
    {
        int index = (value.ToString("F0").Length - 1) / 3;
        double newValue = value / Math.Pow(10, index * 3);
        string result = Format(newValue, decimalPlaces, removeTrailingZeros);

        return result;
    }
}