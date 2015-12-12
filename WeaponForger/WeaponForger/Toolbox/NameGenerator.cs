// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 12/08/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using System;
using System.Collections.Generic;
using WeaponForger.Models;

namespace WeaponForger.Toolbox
{
    public class NameGenerator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameGenerator"/> class.
        /// </summary>
        /// <param name="weapon">The weapon.</param>
        public NameGenerator(Weapon weapon)
        {
            Weapon = weapon;
        }

        #region Properties

        /// <summary>
        /// Gets or sets the weapon.
        /// </summary>
        /// <value>
        /// The weapon.
        /// </value>
        public Weapon Weapon { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Generates this instance.
        /// </summary>
        /// <returns></returns>
        public string Generate()
        {
            if (Weapon == null)
            {
                return "Empty Weapon";
            }

            Name = GenerateSpeedName() + " " + GenerateDamageName() + " " + Weapon.Schematic.Name;

            return Name;
        }

        /// <summary>
        /// Generates the name of the speed.
        /// </summary>
        /// <returns></returns>
        private string GenerateSpeedName()
        {
            var FastList = new List<string>
            {
                "Fast",
                "Agile",
                "Quick",
                "Rapid",
                "Swift",
                "Flashing",
                "Flying",
                "Winged",
                "Light"
            };
            var MediumList = new List<string>
            {
                "Balanced",
                "Harmonious",
                "Standard",
                "Normal",
                "Natural",
                "Regular",
                "Typical",
                "Common"
            };
            var SlowList = new List<string>
            {
                "Slow",
                "Heavy",
                "Easy",
                "Lethargic",
                "Passive",
                "Sluggish",
                "Deliberate",
                "Apathetic"
            };

            var Random = new Random();

            if (Weapon.Speed <= 3)
            {
                return SlowList[Random.Next(0, SlowList.Count - 1)];
            }
            if (3 < Weapon.Speed && Weapon.Speed < 7)
            {
                return MediumList[Random.Next(0, MediumList.Count - 1)];
            }
            return FastList[Random.Next(0, FastList.Count - 1)];
        }

        /// <summary>
        /// Generates the name of the damage.
        /// </summary>
        /// <returns></returns>
        private string GenerateDamageName()
        {
            var HighList = new List<string>
            {
                "Vicious",
                "Cruel",
                "Barbed",
                "Ferocious",
                "Jagged",
                "Serrated",
                "Spiked",
                "Brutal"
            };
            var MediumList = new List<string>
            {
                "Well-Crafted",
                "Powerful",
                "Capable",
                "Dynamic",
                "Potent",
                "Robust"
            };
            var LowList = new List<string>
            {
                "Precision",
                "Narrow",
                "Rigid",
                "Modest",
                "Miniature",
                "Mute",
                "Silent",
                "Hidden"
            };

            var Random = new Random();

            if (Weapon.Damage <= 3)
            {
                return HighList[Random.Next(0, HighList.Count - 1)];
            }
            if (3 < Weapon.Damage && Weapon.Damage < 7)
            {
                return MediumList[Random.Next(0, MediumList.Count - 1)];
            }
            return LowList[Random.Next(0, LowList.Count - 1)];
        }

        #endregion

    }
}