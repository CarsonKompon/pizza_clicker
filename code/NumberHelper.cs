using System;
using System.Globalization;

namespace PizzaClicker;

public static class NumberHelper
{
	public static readonly (string Short, string Long)[] Suffixes =
	{
		("", ""),
		("K", "thousand"),
		("M", "million"),
		("B", "billion"),
		("T", "trillion"),
		("Qa", "quadrillion"),
		("Qi", "quintillion"),
		("Sx", "sextillion"),
		("Sp", "septillion"),
		("Oc", "octillion"),
		("No", "nonillion"),
		("De", "decillion"),
		("Ud", "undecillion"),
		("Dd", "duodecillion"),
		("Td", "tredecillion"),
		("Qad", "quattuordecillion"),
		("Qid", "quindecillion"),
		("Sxd", "sexdecillion"),
		("Spd", "septendecillion"),
		("Ocd", "octodecillion"),
		("Nod", "novemdecillion"),
		("Vg", "vigintillion"),
		("Uvg", "unvigintillion"),
		("Dvg", "duovigintillion"),
		("Tvg", "trevigintillion"),
		("Qavg", "quattuorvigintillion"),
		("Qivg", "quinvigintillion"),
		("Sxvg", "sexvigintillion"),
		("Spvg", "septenvigintillion"),
		("Ocvg", "octovigintillion"),
		("Novg", "novemvigintillion"),
		("Tg", "trigintillion"),
		("Utg", "untrigintillion"),
		("Dtg", "duotrigintillion"),
		("Utg", "tretrigintillion"),
		("Qatg", "quattuortrigintillion"),
		("Qitg", "quintrigintillion"),
		("Sxtg", "sextrigintillion"),
		("Sptg", "septentrigintillion"),
		("Octg", "octotrigintillion"),
		("Notg", "novemtrigintillion"),
		("Qag", "quadragintillion"),
		("Uqag", "unquadragintillion"),
		("Dqag", "duoquadragintillion"),
		("Tqag", "trequadragintillion"),
		("Qaqag", "quattuorquadragintillion"),
		("Qiqag", "quinquadragintillion"),
		("Sxqag", "sexquadragintillion"),
		("Spqag", "septenquadragintillion"),
		("Ocqag", "octoquadragintillion"),
		("Noqag", "novemquadragintillion"),
		("?", "?"),
	};

	public static string Format( double value, int decimalPlaces = 2, bool removeTrailingZeros = true )
	{
		// Return normal string if no decimal value
		if ( decimalPlaces == 0 )
		{
			return value.ToString( "F0" );
		}

		if ( value - Math.Floor( value ) == 0 )
		{
			return value.ToString();
		}

		var result = value.ToString( "F" + decimalPlaces );

		// Remove trailing zeros after decimal
		if ( removeTrailingZeros )
		{
			result = result.TrimEnd( new[] { '0', '.' } );
		}

		return result;
	}

	// To String with commas (such as 1,041 or 1,456,235)
	public static string ToStringWithCommas( double value )
	{
		if ( value == 0 )
		{
			return "0";
		}

		// Return normal string if less than 1000
		if ( value < 1000 )
		{
			return Format( value, 2, true );
		}

		return value.ToString( "##,#", CultureInfo.InvariantCulture );
	}

	// To String with abbreviated suffix (such as 1.04K or 1.46M)
	public static string ToStringAbbreviated( double value, int decimalPlaces = 2, bool removeTrailingZeros = true )
	{
		// Return normal string if less than 1000
		if ( value < 1000 )
		{
			return Format( value, decimalPlaces, removeTrailingZeros );
		}

		var digitCount = value.ToString( "F0" ).Length;

		// Get the suffix
		var index = Math.Min( (digitCount - 1) / 3, Suffixes.Length - 1 );
		var suffix = Suffixes[index].Short;

		// Get the string
		var abbreviation = ConstructAbbreviatedString( value, decimalPlaces, removeTrailingZeros );
		return abbreviation + suffix;
	}

	// To String With Words (such as 1.04 thousand or 1.46 million)
	public static string ToStringWithWords( double value, bool removeTrailingZeros = true )
	{
		// Return normal string if less than 1000
		if ( value < 1000 )
		{
			return value.ToString();
		}

		var digitCount = value.ToString( "F0" ).Length;

		// Get the suffix
		var index = Math.Min( (digitCount - 1) / 3, Suffixes.Length - 1 );
		var suffix = Suffixes[index].Long;

		// Get the string
		var abbreviation = ConstructAbbreviatedString( value, 2, removeTrailingZeros );
		return abbreviation + " " + suffix;
	}

	private static string ConstructAbbreviatedString( double value, int decimalPlaces, bool removeTrailingZeros = true )
	{
		var index = (value.ToString( "F0" ).Length - 1) / 3;
		var newValue = value / Math.Pow( 10, index * 3 );
		var result = Format( newValue, decimalPlaces, removeTrailingZeros );

		return result;
	}
}
