using Evercraft;
using TechTalk.SpecFlow;

namespace Evercraft_WP7_Tests.Steps
{
    public class StepsBase
    {
        protected Character EvercraftCharacter
        {
            get { return ScenarioContext.Current.Get<Character>(); }
            set { ScenarioContext.Current.Set(value);}
        }
    }
}