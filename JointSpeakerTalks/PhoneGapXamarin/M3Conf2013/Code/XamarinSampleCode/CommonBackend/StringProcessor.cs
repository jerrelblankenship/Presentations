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

			    switch (romanCharacter)
			    {
					case 'X':
					    resultNumber += 10;
						break;
					case 'V':
					    resultNumber += 5;
					    break;
					case 'I':
					    resultNumber += 1;
					    break;
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
