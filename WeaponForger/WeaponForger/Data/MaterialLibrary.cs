
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponForger.Enums;
using WeaponForger.Models;

namespace WeaponForger.Data
{
    public class MaterialLibrary
    {
        public MaterialLibrary()
        {
            MaterialsList = new List<Material>();

            var LeadMaterial = new Material
            {
                Id = 1,
                Name = "Lead",
                Weight = 8,
                Hardness = 1.5,
                Resistance = 4.75,
                Type = MaterialType.metal
            };
            MaterialsList.Add(LeadMaterial);
            var TinMaterial = new Material
            {
                Id = 2,
                Name = "Tin",
                Weight = 7,
                Hardness = 1.5,
                Resistance = 4.25,
                Type = MaterialType.metal
            };
            MaterialsList.Add(TinMaterial);
            var GoldMaterial = new Material
            {
                Id = 3,
                Name = "Gold",
                Weight = 9.5,
                Hardness = 2.7,
                Resistance = 6.1,
                Type = MaterialType.metal
            };
            MaterialsList.Add(GoldMaterial);
            var SilverMaterial = new Material
            {
                Id = 5,
                Name = "Silver",
                Weight = 8,
                Hardness = 2.7,
                Resistance = 5.35,
                Type = MaterialType.metal
            };
            MaterialsList.Add(SilverMaterial);
            var CopperMaterial = new Material
            {
                Id = 6,
                Name = "Copper",
                Weight = 7.5,
                Hardness = 3,
                Resistance = 5.25,
                Type = MaterialType.metal
            };
            MaterialsList.Add(CopperMaterial);
            var TungstenMaterial = new Material
            {
                Id = 7,
                Name = "Tungsten",
                Weight = 9.5,
                Hardness = 7.5,
                Resistance = 8.5,
                Type = MaterialType.metal
            };
            MaterialsList.Add(TungstenMaterial);
            var PlatinumMaterial = new Material
            {
                Id = 8,
                Name = "Platinum",
                Weight = 10,
                Hardness = 4.2,
                Resistance = 7.1,
                Type = MaterialType.metal
            };
            MaterialsList.Add(PlatinumMaterial);
            var AluminumMaterial = new Material
            {
                Id = 9,
                Name = "Aluminum",
                Weight = 5,
                Hardness = 2.7,
                Resistance = 3.85,
                Type = MaterialType.metal
            };
            MaterialsList.Add(AluminumMaterial);
            var IronMaterial = new Material
            {
                Id = 10,
                Name = "Iron",
                Weight = 7,
                Hardness = 4.5,
                Resistance = 5.75,
                Type = MaterialType.metal
            };
            MaterialsList.Add(IronMaterial);
            var AspenMaterial = new Material
            {
                Id = 11,
                Name = "Aspen",
                Weight = 4,
                Hardness = 4,
                Resistance = 4,
                Type = MaterialType.wood
            };
            MaterialsList.Add(AspenMaterial);
            var BirchMaterial = new Material
            {
                Id = 12,
                Name = "Birch",
                Weight = 6.5,
                Hardness = 4.5,
                Resistance = 5.5,
                Type = MaterialType.wood
            };
            MaterialsList.Add(BirchMaterial);
            var CedarMaterial = new Material
            {
                Id = 13,
                Name = "Cedar",
                Weight = 4,
                Hardness = 4.5,
                Resistance = 4.25,
                Type = MaterialType.wood
            };
            MaterialsList.Add(CedarMaterial);
            var CherryMaterial = new Material
            {
                Id = 14,
                Name = "Cherry",
                Weight = 6,
                Hardness = 4.5,
                Resistance = 5.25,
                Type = MaterialType.wood
            };
            MaterialsList.Add(CherryMaterial);
            var ChestnutMaterial = new Material
            {
                Id = 15,
                Name = "Chestnut",
                Weight = 5.5,
                Hardness = 2.5,
                Resistance = 4,
                Type = MaterialType.wood
            };
            MaterialsList.Add(ChestnutMaterial);
            var ElmMaterial = new Material
            {
                Id = 16,
                Name = "Elm",
                Weight = 5.5,
                Hardness = 4.5,
                Resistance = 5,
                Type = MaterialType.wood
            };
            MaterialsList.Add(ElmMaterial);
            var RedwoodMaterial = new Material
            {
                Id = 17,
                Name = "Redwood",
                Weight = 4.5,
                Hardness = 2,
                Resistance = 3.25,
                Type = MaterialType.wood
            };
            MaterialsList.Add(RedwoodMaterial);
            var RosewoodMaterial = new Material
            {
                Id = 18,
                Name = "Rosewood",
                Weight = 8,
                Hardness = 8,
                Resistance = 8,
                Type = MaterialType.wood
            };
            MaterialsList.Add(RosewoodMaterial);
            var SpruceMaterial = new Material
            {
                Id = 19,
                Name = "Spruce",
                Weight = 4.5,
                Hardness = 2.5,
                Resistance = 3.5,
                Type = MaterialType.wood
            };
            MaterialsList.Add(SpruceMaterial);
            var YewMaterial = new Material
            {
                Id = 20,
                Name = "Yew",
                Weight = 6.5,
                Hardness = 6,
                Resistance = 6.25,
                Type = MaterialType.wood
            };
            MaterialsList.Add(YewMaterial);
            var DiamondMaterial = new Material
            {
                Id = 21,
                Name = "Diamond",
                Weight = 3.5,
                Hardness = 10,
                Resistance = 6.75,
                Type = MaterialType.gem
            };
            MaterialsList.Add(DiamondMaterial);
            var RubyMaterial = new Material
            {
                Id = 22,
                Name = "Ruby",
                Weight = 4,
                Hardness = 9,
                Resistance = 6.5,
                Type = MaterialType.gem
            };
            MaterialsList.Add(RubyMaterial);
            var SapphireMaterial = new Material
            {
                Id = 23,
                Name = "Sapphire",
                Weight = 4,
                Hardness = 9,
                Resistance = 6.5,
                Type = MaterialType.gem
            };
            MaterialsList.Add(SapphireMaterial);
            var TopazMaterial = new Material
            {
                Id = 24,
                Name = "Topaz",
                Weight = 3.5,
                Hardness = 8,
                Resistance = 5.75,
                Type = MaterialType.gem
            };
            MaterialsList.Add(TopazMaterial);
            var EmeraldMaterial = new Material
            {
                Id = 25,
                Name = "Emerald",
                Weight = 2.5,
                Hardness = 7.5,
                Resistance = 5,
                Type = MaterialType.gem
            };
            MaterialsList.Add(EmeraldMaterial);
            var QuartzMaterial = new Material
            {
                Id = 26,
                Name = "Quartz",
                Weight = 2.5,
                Hardness = 7,
                Resistance = 4.75,
                Type = MaterialType.gem
            };
            MaterialsList.Add(QuartzMaterial);
            var OpalMaterial = new Material
            {
                Id = 27,
                Name = "Opal",
                Weight = 2,
                Hardness = 6.5,
                Resistance = 4.25,
                Type = MaterialType.gem
            };
            MaterialsList.Add(OpalMaterial);
            var GlassMaterial = new Material
            {
                Id = 28,
                Name = "Glass",
                Weight = 2.5,
                Hardness = 5.5,
                Resistance = 4,
                Type = MaterialType.gem
            };
            MaterialsList.Add(GlassMaterial);
            var ObsidianMaterial = new Material
            {
                Id = 29,
                Name = "Obsidian",
                Weight = 2.5,
                Hardness = 5,
                Resistance = 3.75,
                Type = MaterialType.gem
            };
            MaterialsList.Add(ObsidianMaterial);
            var IceMaterial = new Material
            {
                Id = 30,
                Name = "Ice",
                Weight = 1,
                Hardness = 1.5,
                Resistance = 1.25,
                Type = MaterialType.gem
            };
            MaterialsList.Add(IceMaterial);
            var CottonMaterial = new Material
            {
                Id = 31,
                Name = "Cotton",
                Weight = 2,
                Hardness = 2.5,
                Resistance = 2.25,
                Type = MaterialType.cloth
            };
            MaterialsList.Add(CottonMaterial);
            var LinenMaterial = new Material
            {
                Id = 32,
                Name = "Linen",
                Weight = 1,
                Hardness = 1,
                Resistance = 1,
                Type = MaterialType.cloth
            };
            MaterialsList.Add(LinenMaterial);
            var SilkMaterial = new Material
            {
                Id = 33,
                Name = "Silk",
                Weight = 3,
                Hardness = 2,
                Resistance = 2.5,
                Type = MaterialType.cloth
            };
            MaterialsList.Add(SilkMaterial);
            var CanvasMaterial = new Material
            {
                Id = 34,
                Name = "Canvas",
                Weight = 2.5,
                Hardness = 3,
                Resistance = 2.75,
                Type = MaterialType.cloth
            };
            MaterialsList.Add(CanvasMaterial);
            var VelvetMaterial = new Material
            {
                Id = 35,
                Name = "Velvet",
                Weight = 1.5,
                Hardness = 1.5,
                Resistance = 1.5,
                Type = MaterialType.cloth
            };
            MaterialsList.Add(VelvetMaterial);
            var BearMaterial = new Material
            {
                Id = 36,
                Name = "Bear",
                Weight = 6,
                Hardness = 6,
                Resistance = 6,
                Type = MaterialType.leather
            };
            MaterialsList.Add(BearMaterial);
            var DeerMaterial = new Material
            {
                Id = 37,
                Name = "Deer",
                Weight = 4.5,
                Hardness = 4.5,
                Resistance = 4.5,
                Type = MaterialType.leather
            };
            MaterialsList.Add(DeerMaterial);
            var WolfMaterial = new Material
            {
                Id = 38,
                Name = "Wolf",
                Weight = 5,
                Hardness = 5,
                Resistance = 5,
                Type = MaterialType.leather
            };
            MaterialsList.Add(WolfMaterial);
            var RabbitMaterial = new Material
            {
                Id = 39,
                Name = "Rabbit",
                Weight = 4,
                Hardness = 4,
                Resistance = 4,
                Type = MaterialType.leather
            };
            MaterialsList.Add(RabbitMaterial);
            var BovineMaterial = new Material
            {
                Id = 40,
                Name = "Bovine",
                Weight = 5.5,
                Hardness = 5.5,
                Resistance = 5.5,
                Type = MaterialType.leather
            };
            MaterialsList.Add(BovineMaterial);
        }

        public List<Material> MaterialsList { get; set; } 
    }
}
