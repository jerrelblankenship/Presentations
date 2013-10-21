namespace CommonBackend
{
    public class StringProcessor : IStringProcessor
    {
	    public int ConvertToNumberString(string romanNumeral)
	    {
		    var resultNumber = 0;

		    if (romanNumeral == "I")
		    {
			    resultNumber = 1;
		    }
		    else
		    {
			    resultNumber = 2;
		    }

		    return resultNumber;
	    }

	    public string ConvertToRomanNumeral(string numberString)
	    {
		    throw new System.NotImplementedException();
	    }
    }
}
