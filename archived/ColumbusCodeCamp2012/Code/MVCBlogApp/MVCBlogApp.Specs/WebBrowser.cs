using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace MVCBlogApp.Specs
{
    [Binding]
    public class WebBrowser
    {
        public static Browser CurrentBrowser
        {
            get
            {
                if (!FeatureContext.Current.ContainsKey("browser"))
                {
                    FeatureContext.Current["browser"] = GetWebDriver();
                }

                return (Browser) FeatureContext.Current["browser"];
            }
        }

        private static Browser GetWebDriver()
        {
            return new IE();
        }
    }
}
