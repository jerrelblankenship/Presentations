using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Evercraft;
using TechTalk.SpecFlow;

namespace Evercraft_WP7_Tests.Steps
{
    [Binding]
    public class GlobalSteps : StepsBase
    {
        [Given(@"I have a new character")]
        public void GivenIHaveANewCharacter()
        {
            EvercraftCharacter = new Character();
        }
    }
}
