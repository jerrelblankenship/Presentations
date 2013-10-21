namespace CommonBackend
{
	public interface IStringProcessor
	{
		int ConvertToNumberString(string romanNumeral);
		string ConvertToRomanNumeral(string numberString);
	}
}