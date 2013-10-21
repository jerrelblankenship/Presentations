namespace CommonBackend.Tests
{
	using NUnit.Framework;

	[TestFixture]
    public class StringProcessorTests
	{
		private StringProcessor _sProcessor;
		
		[SetUp]
		public void Setup()
		{
			_sProcessor = new StringProcessor();
		}

		[Test]
		public void ConvertToNumberString_returns_1_for_I()
		{
			var result = _sProcessor.ConvertToNumberString("I");
			Assert.That(result, Is.EqualTo(1));
		}

		[Test]
		public void ConvertToNumberString_returns_2_for_II()
		{
			var result = _sProcessor.ConvertToNumberString("II");
			Assert.That(result, Is.EqualTo(2));
		}

		[Test]
		public void ConvertToNumberString_returns_3_for_III()
		{
			var result = _sProcessor.ConvertToNumberString("III");
			Assert.That(result, Is.EqualTo(3));
		}

		[Test]
		public void ConvertToNumberString_returns_5_for_V()
		{
			var result = _sProcessor.ConvertToNumberString("V");
			Assert.That(result, Is.EqualTo(5));
		}

		[Test]
		public void ConvertToNumberString_returns_6_for_VI()
		{
			var result = _sProcessor.ConvertToNumberString("VI");
			Assert.That(result, Is.EqualTo(6));
		}

		[Test]
		public void ConvertToNumberString_returns_10_for_X()
		{
			var result = _sProcessor.ConvertToNumberString("X");
			Assert.That(result, Is.EqualTo(10));
		}

		[Test]
		public void ConvertToNumberString_returns_4_for_IV()
		{
			var result = _sProcessor.ConvertToNumberString("IV");
			Assert.That(result, Is.EqualTo(4));
		}
	}
}
