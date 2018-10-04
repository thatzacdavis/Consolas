using System;
using Xunit;

namespace Consolas.Tests
{
    public class WeaponServiceTests
    {
        private readonly WeaponService _weaponService = new WeaponService();

        [Fact]
        public void WeaponServiceReturnsAxeForA()
        {
            string weaponChoice = _weaponService.ConvertWeaponChoiceToWeaponName("a");
            Assert.True(weaponChoice == "Axe");
        }

        [Fact]
        public void WeaponServiceReturnsBowForB()
        {
            string weaponChoice = _weaponService.ConvertWeaponChoiceToWeaponName("b");
            Assert.True(weaponChoice == "Bow");
        }

        [Fact]
        public void WeaponServiceReturnsKnifeForK()
        {
            string weaponChoice = _weaponService.ConvertWeaponChoiceToWeaponName("k");
            Assert.True(weaponChoice == "Knife");
        }

        [Fact]
        public void WeaponServiceReturnsSwordForS()
        {
            string weaponChoice = _weaponService.ConvertWeaponChoiceToWeaponName("s");
            Assert.True(weaponChoice == "Sword");
        }

        [Fact]
        public void WeaponServiceReturnsWandForW()
        {
            string weaponChoice = _weaponService.ConvertWeaponChoiceToWeaponName("w");
            Assert.True(weaponChoice == "Wand");
        }

        [Fact]
        public void WeaponServiceReturnsWandForCapitalW()
        {
            string weaponChoice = _weaponService.ConvertWeaponChoiceToWeaponName("W");
            Assert.True(weaponChoice == "Wand");
        }

        [Fact]
        public void WeaponServiceReturnsFistsForAnyOtherLetter()
        {
            string weaponChoice = _weaponService.ConvertWeaponChoiceToWeaponName("z");
            Assert.True(weaponChoice == "Fists");
        }

        [Fact]
        public void WeaponServiceReturnsFistsForAnyNumber()
        {
            string weaponChoice = _weaponService.ConvertWeaponChoiceToWeaponName("3");
            Assert.True(weaponChoice == "Fists");
        }
    }
}
