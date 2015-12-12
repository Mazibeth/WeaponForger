// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 10/30/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

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