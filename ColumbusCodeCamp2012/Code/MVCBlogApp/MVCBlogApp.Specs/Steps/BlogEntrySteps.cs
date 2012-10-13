using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WatiN.Core;

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

        [Given]
        public void Given_I_am_on_the_P0(string p0)
        {
            GivenINavigateToTheBlogApplication();

            var bodyText = p0.Replace("\"", "");
            ThenIShouldSeeThe(bodyText);
        }

        [Given(@"I click on the ""(.*)"" button")]
        public void GivenIClickOnTheButton(string p0)
        {
            When_I_click_on_the_P0_button(p0);
        }


        [When]
        public void When_I_click_on_the_P0_button(string p0)
        {
            var elementId = p0.Replace("\"", "");
            var link = WebBrowser.CurrentBrowser.Link(elementId);
            link.Click();
        }

        [When(@"I submit the form")]
        public void WhenISubmitTheForm()
        {
            var button = WebBrowser.CurrentBrowser.Button("Submit");
            button.Click();
        }


        [When]
        public void When_I_enter_the_title_P0(string p0)
        {
            var text = p0.Replace("\"", "");
            var textbox = WebBrowser.CurrentBrowser.TextField("Title");
            textbox.TypeText(text);
        }

        [When]
        public void When_I_enter_the_body_P0(string p0)
        {
            var text = p0.Replace("\"", "");
            var textbox = WebBrowser.CurrentBrowser.TextField("Body");
            textbox.TypeText(text);
        }

        [Then(@"I should see ""(.*)"" on the page")]
        public void ThenIShouldSeeOnThePage(string p0)
        {
            var result = p0.Replace("\"", "");
            Assert.That(WebBrowser.CurrentBrowser.ContainsText(result));
        }


        [AfterFeature()]
        public static void TearDown()
        {
            WebBrowser.CurrentBrowser.Close();
        }
    }
}
