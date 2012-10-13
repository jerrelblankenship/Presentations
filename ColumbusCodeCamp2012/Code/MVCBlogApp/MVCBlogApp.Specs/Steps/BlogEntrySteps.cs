using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MVCBlogApp.Specs.Steps
{
    [Binding]
    public class BlogEntrySteps
    {
        [Given(@"I navigate to the Blog Application")]
        public void GivenINavigateToTheBlogApplication()
        {
            WebBrowser.CurrentBrowser.GoTo("http://localhost:12345/Blog");
        }

        [Then(@"I should see the ""(.*)""")]
        public void ThenIShouldSeeThe(string p0)
        {
            Assert.That(WebBrowser.CurrentBrowser.ContainsText(p0));
        }


        [AfterFeature()]
        public static void TearDown()
        {
            WebBrowser.CurrentBrowser.Close();
        }
    }
}
