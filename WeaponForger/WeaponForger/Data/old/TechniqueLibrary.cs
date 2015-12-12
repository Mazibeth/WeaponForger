
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponForger.Models;

namespace WeaponForger.Data
{
    public class TechniqueLibrary
    {
        public TechniqueLibrary()
        {
            Techniques = new List<Technique>();

			var LeadTechnique = new Technique
            {
                Name = "Lead",
                Primary = "Metal",
                Secondary = "8",
                Tertiary = "1.5"
            };
            Techniques.Add(LeadTechnique);
			var TinTechnique = new Technique
            {
                Name = "Tin",
                Primary = "Metal",
                Secondary = "7",
                Tertiary = "1.5"
            };
            Techniques.Add(TinTechnique);
			var GoldTechnique = new Technique
            {
                Name = "Gold",
                Primary = "Metal",
                Secondary = "9.5",
                Tertiary = "2.7"
            };
            Techniques.Add(GoldTechnique);
			var SilverTechnique = new Technique
            {
                Name = "Silver",
                Primary = "Metal",
                Secondary = "8",
                Tertiary = "2.7"
            };
            Techniques.Add(SilverTechnique);
			var CopperTechnique = new Technique
            {
                Name = "Copper",
                Primary = "Metal",
                Secondary = "7.5",
                Tertiary = "3"
            };
            Techniques.Add(CopperTechnique);
			var TungstenTechnique = new Technique
            {
                Name = "Tungsten",
                Primary = "Metal",
                Secondary = "9.5",
                Tertiary = "7.5"
            };
            Techniques.Add(TungstenTechnique);
			var PlatinumTechnique = new Technique
            {
                Name = "Platinum",
                Primary = "Metal",
                Secondary = "10",
                Tertiary = "4.2"
            };
            Techniques.Add(PlatinumTechnique);
			var AluminumTechnique = new Technique
            {
                Name = "Aluminum",
                Primary = "Metal",
                Secondary = "5",
                Tertiary = "2.7"
            };
            Techniques.Add(AluminumTechnique);
			var IronTechnique = new Technique
            {
                Name = "Iron",
                Primary = "Metal",
                Secondary = "7",
                Tertiary = "4.5"
            };
            Techniques.Add(IronTechnique);
			var AspenTechnique = new Technique
            {
                Name = "Aspen",
                Primary = "Wood",
                Secondary = "4",
                Tertiary = "4"
            };
            Techniques.Add(AspenTechnique);
			var BirchTechnique = new Technique
            {
                Name = "Birch",
                Primary = "Wood",
                Secondary = "6.5",
                Tertiary = "4.5"
            };
            Techniques.Add(BirchTechnique);
			var CedarTechnique = new Technique
            {
                Name = "Cedar",
                Primary = "Wood",
                Secondary = "4",
                Tertiary = "4.5"
            };
            Techniques.Add(CedarTechnique);
			var CherryTechnique = new Technique
            {
                Name = "Cherry",
                Primary = "Wood",
                Secondary = "6",
                Tertiary = "4.5"
            };
            Techniques.Add(CherryTechnique);
			var ChestnutTechnique = new Technique
            {
                Name = "Chestnut",
                Primary = "Wood",
                Secondary = "5.5",
                Tertiary = "2.5"
            };
            Techniques.Add(ChestnutTechnique);
			var ElmTechnique = new Technique
            {
                Name = "Elm",
                Primary = "Wood",
                Secondary = "5.5",
                Tertiary = "4.5"
            };
            Techniques.Add(ElmTechnique);
			var RedwoodTechnique = new Technique
            {
                Name = "Redwood",
                Primary = "Wood",
                Secondary = "4.5",
                Tertiary = "2"
            };
            Techniques.Add(RedwoodTechnique);
			var RosewoodTechnique = new Technique
            {
                Name = "Rosewood",
                Primary = "Wood",
                Secondary = "8",
                Tertiary = "8"
            };
            Techniques.Add(RosewoodTechnique);
			var SpruceTechnique = new Technique
            {
                Name = "Spruce",
                Primary = "Wood",
                Secondary = "4.5",
                Tertiary = "2.5"
            };
            Techniques.Add(SpruceTechnique);
			var YewTechnique = new Technique
            {
                Name = "Yew",
                Primary = "Wood",
                Secondary = "6.5",
                Tertiary = "6"
            };
            Techniques.Add(YewTechnique);
			var DiamondTechnique = new Technique
            {
                Name = "Diamond",
                Primary = "Gem",
                Secondary = "3.5",
                Tertiary = "10"
            };
            Techniques.Add(DiamondTechnique);
			var RubyTechnique = new Technique
            {
                Name = "Ruby",
                Primary = "Gem",
                Secondary = "4",
                Tertiary = "9"
            };
            Techniques.Add(RubyTechnique);
			var SapphireTechnique = new Technique
            {
                Name = "Sapphire",
                Primary = "Gem",
                Secondary = "4",
                Tertiary = "9"
            };
            Techniques.Add(SapphireTechnique);
			var TopazTechnique = new Technique
            {
                Name = "Topaz",
                Primary = "Gem",
                Secondary = "3.5",
                Tertiary = "8"
            };
            Techniques.Add(TopazTechnique);
			var EmeraldTechnique = new Technique
            {
                Name = "Emerald",
                Primary = "Gem",
                Secondary = "2.5",
                Tertiary = "7.5"
            };
            Techniques.Add(EmeraldTechnique);
			var QuartzTechnique = new Technique
            {
                Name = "Quartz",
                Primary = "Gem",
                Secondary = "2.5",
                Tertiary = "7"
            };
            Techniques.Add(QuartzTechnique);
			var OpalTechnique = new Technique
            {
                Name = "Opal",
                Primary = "Gem",
                Secondary = "2",
                Tertiary = "6.5"
            };
            Techniques.Add(OpalTechnique);
			var GlassTechnique = new Technique
            {
                Name = "Glass",
                Primary = "Gem",
                Secondary = "2.5",
                Tertiary = "5.5"
            };
            Techniques.Add(GlassTechnique);
			var ObsidianTechnique = new Technique
            {
                Name = "Obsidian",
                Primary = "Gem",
                Secondary = "2.5",
                Tertiary = "5"
            };
            Techniques.Add(ObsidianTechnique);
			var IceTechnique = new Technique
            {
                Name = "Ice",
                Primary = "Gem",
                Secondary = "1",
                Tertiary = "1.5"
            };
            Techniques.Add(IceTechnique);
			var CottonTechnique = new Technique
            {
                Name = "Cotton",
                Primary = "Cloth",
                Secondary = "2",
                Tertiary = "2.5"
            };
            Techniques.Add(CottonTechnique);
			var LinenTechnique = new Technique
            {
                Name = "Linen",
                Primary = "Cloth",
                Secondary = "1",
                Tertiary = "1"
            };
            Techniques.Add(LinenTechnique);
			var SilkTechnique = new Technique
            {
                Name = "Silk",
                Primary = "Cloth",
                Secondary = "3",
                Tertiary = "2"
            };
            Techniques.Add(SilkTechnique);
			var CanvasTechnique = new Technique
            {
                Name = "Canvas",
                Primary = "Cloth",
                Secondary = "2.5",
                Tertiary = "3"
            };
            Techniques.Add(CanvasTechnique);
			var VelvetTechnique = new Technique
            {
                Name = "Velvet",
                Primary = "Cloth",
                Secondary = "1.5",
                Tertiary = "1.5"
            };
            Techniques.Add(VelvetTechnique);
			var BearTechnique = new Technique
            {
                Name = "Bear",
                Primary = "Leather",
                Secondary = "6",
                Tertiary = "6"
            };
            Techniques.Add(BearTechnique);
			var DeerTechnique = new Technique
            {
                Name = "Deer",
                Primary = "Leather",
                Secondary = "4.5",
                Tertiary = "4.5"
            };
            Techniques.Add(DeerTechnique);
			var WolfTechnique = new Technique
            {
                Name = "Wolf",
                Primary = "Leather",
                Secondary = "5",
                Tertiary = "5"
            };
            Techniques.Add(WolfTechnique);
			var RabbitTechnique = new Technique
            {
                Name = "Rabbit",
                Primary = "Leather",
                Secondary = "4",
                Tertiary = "4"
            };
            Techniques.Add(RabbitTechnique);
			var BovineTechnique = new Technique
            {
                Name = "Bovine",
                Primary = "Leather",
                Secondary = "5.5",
                Tertiary = "5.5"
            };
            Techniques.Add(BovineTechnique);
        }

        public List<Technique> Techniques { get; set; } 
    }
}
