namespace XamlBasedAppExample
{
    public class RomanConverter
    {
        public string RomanNumeralConverter(int i)
        {
            string rom = string.Empty;
            while (i > 0)
            {
                rom = rom + "I";
                i--;
            }
            return rom;
        }
    }
}