using System;
using System.Collections.Generic;
using WeaponForger.Models;

namespace WeaponForger.Toolbox
{
    public class NameGenerator
    {
        public NameGenerator(Weapon weapon)
        {
            Weapon = weapon;
        }

        public Weapon Weapon { get; set; }
        public string Name { get; set; }

        public string Generate()
        {
            if (Weapon == null)
            {
                return "Empty Weapon";
            }

            Name = GenerateSpeedName() + " " + GenerateDamageName() + " " + Weapon.Schematic.Name;

            return Name;
        }

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
    }
}