namespace RomanConverter_XAML.Processor
{
    using System.Text;

    public class RomanConverter
    {
        public string ConvertToRoman(int number)
        {
            var result = new StringBuilder();


            if (number >= 5)
            {
                result.Append("V");
                number = number - 5;
            }

            for (var i = 1; i <= number; i++)
            {
                result.Append("I");
            }

            return result.ToString();
        }
    }
}