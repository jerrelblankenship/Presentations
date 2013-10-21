namespace CommonBackend.Tests
{
	using NUnit.Framework;

	[TestFixture]
    public class StringProcessorTests
	{
		[Test]
		public void ConvertToNumberString_returns_1_for_I()
		{
			var sProcessor = new StringProcessor();
			var result = sProcessor.ConvertToNumberString("I");
			Assert.That(result, Is.EqualTo(1));
		}

		[Test]
		public void ConvertToNumberString_returns_2_for_II()
		{
			
		}
	}
}
