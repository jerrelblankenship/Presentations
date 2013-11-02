namespace RomanConverter_XAML.Tests.NUnit
{
    using global::NUnit.Framework;
    using Processor;

    [TestFixture]
    public class RomanConverterNUnit
    {
        [Test]
        public void romanConverter_returns_I_when_given_1_NUnit()
        {
            var converter = new RomanConverter();
            var result = converter.ConvertToRoman(1);

            Assert.That(result, Is.EqualTo("I"));
        }

        [Test]
        public void romanConverter_returns_II_when_given_2_NUnit()
        {
            var converter = new RomanConverter();
            var result = converter.ConvertToRoman(2);

            Assert.That(result, Is.EqualTo("II"));
        }

        [Test]
        public void romanConverter_returns_III_when_given_3_NUnit()
        {
            var converter = new RomanConverter();
            var result = converter.ConvertToRoman(3);

            Assert.That(result, Is.EqualTo("III"));
        }

        [Test]
        public void romanConverter_returns_V_when_given_5_NUnit()
        {
            var converter = new RomanConverter();
            var result = converter.ConvertToRoman(5);

            Assert.That(result, Is.EqualTo("V"));
        }
    }
}
