using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Evercraft;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Evercraft_WP7_Tests.Steps
{
    [Binding]
    public class CharacterSteps : StepsBase
    {
        [When(@"I give it the name of ""(.*)""")]
        public void WhenIGiveItTheNameOf(string characterName)
        {
            EvercraftCharacter.Name = characterName;
        }

        [Then(@"the character's name should be ""(.*)""")]
        public void ThenTheCharacterSNameShouldBe(string characterName)
        {
            Assert.AreEqual(characterName, EvercraftCharacter.Name);
        }

        [When(@"I mark the character's alignment as (.*)")]
        public void WhenIMarkTheCharacterAlignment(string alignment)
        {
            var alignmentEnum = (AlignmentEnum)Enum.Parse(typeof(AlignmentEnum), alignment, true);
            EvercraftCharacter.Alignment = alignmentEnum;
        }

        [Then(@"the character's alignment should be (.*)")]
        public void ThenTheCharacterSAlignmentShouldBe(string alignment)
        {
            var alignmentEnum = Enum.Parse(typeof(AlignmentEnum), alignment, true);
            Assert.AreEqual(alignmentEnum, EvercraftCharacter.Alignment);
        }
    }
}
