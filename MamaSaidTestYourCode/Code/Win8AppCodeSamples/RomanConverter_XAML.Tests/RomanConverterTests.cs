using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace RomanConverter_XAML.Tests
{
    using Processor;

    [TestClass]
    public class RomanConverterTests
    {
        [TestMethod]
        public void romanConverter_returns_I_when_given_1()
        {
            var converter = new RomanConverter();
            var result = converter.ConvertToRoman(1);

            Assert.AreEqual("I", result);
        }

        [TestMethod]
        public void romanConverter_returns_II_when_given_2()
        {
            var converter = new RomanConverter();
            var result = converter.ConvertToRoman(2);

            Assert.AreEqual("II", result);
        }

        [TestMethod]
        public void romanConverter_returns_III_when_given_3()
        {
            var converter = new RomanConverter();
            var result = converter.ConvertToRoman(3);

            Assert.AreEqual("III", result);
        }

        [TestMethod]
        public void romanConverter_returns_V_when_given_5()
        {
            var converter = new RomanConverter();
            var result = converter.ConvertToRoman(5);

            Assert.AreEqual("V", result);
        }
    }
}
