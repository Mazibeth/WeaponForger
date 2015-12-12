// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 11/29/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using System.Collections.Generic;
using WeaponForger.Models;

namespace WeaponForger.Data
{
    public class SchematicLibrary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchematicLibrary"/> class.
        /// </summary>
        public SchematicLibrary()
        {
            Schematics = new List<Schematic>();

            var DaggerSchematic = new Schematic
            {
                Id = 1,
                Name = "Dagger",
                Slot = new[]
                {
                    'x', 'x', 'x', 'x', 'x',
                    'x', 'x', 'p', 'x', 'x',
                    'x', 'x', 't', 'x', 'x',
                    'x', 'x', 's', 'x', 'x',
                    'x', 'x', 'x', 'x', 'x'
                }
            };
            Schematics.Add(DaggerSchematic);
            var ShortSwordSchematic = new Schematic
            {
                Id = 2,
                Name = "Short Sword",
                Slot = new[]
                {
                    'x', 'x', 'p', 'x', 'x',
                    'x', 'x', 'p', 'x', 'x',
                    'x', 'x', 's', 'x', 'x',
                    'x', 'x', 't', 'x', 'x',
                    'x', 'x', 'x', 'x', 'x'
                }
            };
            Schematics.Add(ShortSwordSchematic);
            var LongswordSchematic = new Schematic
            {
                Id = 3,
                Name = "Longsword",
                Slot = new[]
                {
                    'x', 'x', 'p', 'x', 'x',
                    'x', 'x', 'p', 'x', 'x',
                    'x', 'x', 'p', 'x', 'x',
                    'x', 'x', 's', 'x', 'x',
                    'x', 'x', 't', 'x', 'x'
                }
            };
            Schematics.Add(LongswordSchematic);
            var GreatswordSchematic = new Schematic
            {
                Id = 4,
                Name = "Greatsword",
                Slot = new[]
                {
                    'x', 'x', 'p', 'x', 'x',
                    'x', 'x', 'p', 'p', 'x',
                    'x', 'x', 'p', 'p', 'x',
                    'x', 'x', 's', 't', 'x',
                    'x', 'x', 's', 'x', 'x'
                }
            };
            Schematics.Add(GreatswordSchematic);
            var BastardSwordSchematic = new Schematic
            {
                Id = 5,
                Name = "Bastard Sword",
                Slot = new[]
                {
                    'x', 'x', 'p', 'x', 'x',
                    'x', 'x', 'p', 'p', 'x',
                    'x', 'x', 'p', 'x', 'x',
                    'x', 'x', 's', 't', 'x',
                    'x', 'x', 's', 'x', 'x'
                }
            };
            Schematics.Add(BastardSwordSchematic);
            var BucklerSchematic = new Schematic
            {
                Id = 6,
                Name = "Buckler",
                Slot = new[]
                {
                    'x', 'x', 'x', 'x', 'x',
                    'x', 'x', 'p', 'x', 'x',
                    'x', 'p', 's', 'p', 'x',
                    'x', 'x', 'p', 't', 'x',
                    'x', 'x', 'x', 'x', 'x'
                }
            };
            Schematics.Add(BucklerSchematic);
            var RoundShieldSchematic = new Schematic
            {
                Id = 7,
                Name = "Round Shield",
                Slot = new[]
                {
                    'x', 'x', 'p', 'x', 'x',
                    'x', 'p', 'p', 'p', 'x',
                    'p', 'p', 's', 'p', 'p',
                    'x', 'p', 'p', 'p', 't',
                    'x', 'x', 'p', 'x', 'x'
                }
            };
            Schematics.Add(RoundShieldSchematic);
            var TowerShieldSchematic = new Schematic
            {
                Id = 8,
                Name = "Tower Shield",
                Slot = new[]
                {
                    'x', 'x', 't', 'x', 'x',
                    's', 'p', 'p', 'p', 's',
                    's', 'p', 'p', 'p', 's',
                    's', 'p', 'p', 'p', 's',
                    'x', 'x', 'x', 'x', 'x'
                }
            };
            Schematics.Add(TowerShieldSchematic);
            var HatchetSchematic = new Schematic
            {
                Id = 9,
                Name = "Hatchet",
                Slot = new[]
                {
                    'x', 'x', 'x', 'x', 'x',
                    'x', 'x', 'p', 'p', 'x',
                    'x', 'x', 's', 'x', 'x',
                    'x', 'x', 's', 't', 'x',
                    'x', 'x', 'x', 'x', 'x'
                }
            };
            Schematics.Add(HatchetSchematic);
            var AxeSchematic = new Schematic
            {
                Id = 10,
                Name = "Axe",
                Slot = new[]
                {
                    'x', 'x', 'x', 'x', 'x',
                    'x', 'p', 'p', 'p', 'x',
                    'x', 'x', 's', 'x', 'x',
                    'x', 'x', 's', 't', 'x',
                    'x', 'x', 'x', 'x', 'x'
                }
            };
            Schematics.Add(AxeSchematic);
        }

        /// <summary>
        /// Gets or sets the schematics.
        /// </summary>
        /// <value>
        /// The schematics.
        /// </value>
        public List<Schematic> Schematics { get; set; }
    }
}