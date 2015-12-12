using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeaponForger.Models;

namespace WeaponForger.Tests
{
    [TestClass]
    public class WeaponTest
    {
        [TestMethod]
        public void ValidateWeaponName()
        {
            var TestWeapon = new Weapon();
            TestWeapon.GenerateWeapon();

            var result = TestWeapon.Name;

            Assert.AreNotEqual(result, "Default Name");
        }

        [TestMethod]
        public void ValidateWeaponSpeed()
        {
            var TestWeapon = new Weapon();
            TestWeapon.GenerateWeapon();

            var result = TestWeapon.Speed;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ValidateWeaponDamage()
        {
            var TestWeapon = new Weapon();
            TestWeapon.GenerateWeapon();

            var result = TestWeapon.Damage;

            Assert.IsNotNull(result);
        }
    }
}