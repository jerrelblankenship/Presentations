using System;

namespace RomanConverterSharedBase
{
	using System.Text;

	public class RomanNumeralConverter
	{
		public string NumberToRoman(int number)
		{
			var romanNumber = new StringBuilder();

			while (number > 0)
			{
				if (number >= 10)
				{
					romanNumber.Append("X");
					number -= 10;
				}
				else if (number >= 9)
				{
					romanNumber.Append("IX");
					number -= 9;
				}
				else if (number >= 5)
				{
					romanNumber.Append("V");
					number -= 5;
				}
				else if (number >= 4)
				{
					romanNumber.Append("IV");
					number -= 4;
				}
				else if (number >= 1)
				{
					romanNumber.Append("I");
					number -= 1;
				}
			}
			return romanNumber.ToString();
		}
	}
}

