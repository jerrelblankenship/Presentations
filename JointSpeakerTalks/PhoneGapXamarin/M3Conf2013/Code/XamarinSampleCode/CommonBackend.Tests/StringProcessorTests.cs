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
	}
}
