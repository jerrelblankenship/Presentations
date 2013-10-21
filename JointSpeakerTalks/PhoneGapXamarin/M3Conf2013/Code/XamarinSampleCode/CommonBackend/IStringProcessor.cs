namespace CommonBackend
{
	public interface IStringProcessor
	{
		string ConvertToNumberString(string romanNumeral);
		string ConvertToRomanNumeral(string numberString);
	}
}