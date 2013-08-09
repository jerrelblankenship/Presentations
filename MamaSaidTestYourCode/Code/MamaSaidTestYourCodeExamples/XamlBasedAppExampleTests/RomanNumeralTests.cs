using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using XamlBasedAppExample;

namespace XamlBasedAppExampleTests
{
    [TestClass]
    public class RomanNumeralTests
    {
        [TestMethod]
        public void romanNumeralConverter_when_given_1_returns_I()
        {
            var converter = new RomanConverter();
            var result = converter.RomanNumeralConverter(1);

            Assert.AreEqual("I", result);
        }

        [TestMethod]
        public void romanNumeralConverter_when_given_2_returns_II()
        {
            var converter = new RomanConverter();
            var result = converter.RomanNumeralConverter(2);

            Assert.AreEqual("II", result);
        }

        [TestMethod]
        public void romanNumeralConverter_when_given_3_returns_III()
        {
            var converter = new RomanConverter();
            var result = converter.RomanNumeralConverter(3);

            Assert.AreEqual("III", result);
        }
    }
}
