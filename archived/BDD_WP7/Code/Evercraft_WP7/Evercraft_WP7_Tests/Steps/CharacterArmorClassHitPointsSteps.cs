using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Evercraft_WP7_Tests.Steps
{
    [Binding]
    public class CharacterArmorClassHitPointsSteps : StepsBase
    {
        [Then(@"the Character has a default Armor Class of (\d+)")]
        public void ThenTheCharacterHasADefaultBaseArmorClassOf(int armorClass)
        {
            Assert.AreEqual(armorClass, EvercraftCharacter.ArmorClass);
        }

        [Then(@"the character has a default hit points of (\d+)")]
        public void ThenTheCharacterHasADefaultHitPointsOf(int hitPoints)
        {
            Assert.AreEqual(hitPoints, EvercraftCharacter.HitPoints);
        }
    }
}
