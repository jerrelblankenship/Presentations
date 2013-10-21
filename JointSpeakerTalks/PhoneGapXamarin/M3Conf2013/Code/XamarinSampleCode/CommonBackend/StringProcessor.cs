namespace CommonBackend
{
    public class StringProcessor : IStringProcessor
    {
	    public int ConvertToNumberString(string romanNumeral)
	    {
		    var resultNumber = 0;

		    var romanCharacters = romanNumeral.ToCharArray();

		    foreach (var romanCharacter in romanNumeral)
		    {
			    if (romanCharacter == 'V')
			    {
				    resultNumber += 5;
			    }
			    else
			    {
					resultNumber += 1;				    
			    }
		    }

		    return resultNumber;
	    }

	    public string ConvertToRomanNumeral(string numberString)
	    {
		    throw new System.NotImplementedException();
	    }
    }
}
