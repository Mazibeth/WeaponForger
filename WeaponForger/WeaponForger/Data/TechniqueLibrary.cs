
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponForger.Enums;
using WeaponForger.Models;

namespace WeaponForger.Data
{
    public class TechniqueLibrary
    {
        public TechniqueLibrary()
        {
            Techniques = new List<Technique>();

			var CastTechnique = new Technique
            {
				Id = 1,
                Name = "Cast",
                Primary = MaterialType.metal,
                Secondary = MaterialType.wood,
                Tertiary = MaterialType.gem
            };
            Techniques.Add(CastTechnique);
			var FoldTechnique = new Technique
            {
				Id = 2,
                Name = "Fold",
                Primary = MaterialType.metal,
                Secondary = MaterialType.cloth,
                Tertiary = MaterialType.wood
            };
            Techniques.Add(FoldTechnique);
			var GrindTechnique = new Technique
            {
				Id = 3,
                Name = "Grind",
                Primary = MaterialType.gem,
                Secondary = MaterialType.metal,
                Tertiary = MaterialType.cloth
            };
            Techniques.Add(GrindTechnique);
			var WrapTechnique = new Technique
            {
				Id = 4,
                Name = "Wrap",
                Primary = MaterialType.gem,
                Secondary = MaterialType.leather,
                Tertiary = MaterialType.wood
            };
            Techniques.Add(WrapTechnique);
			var CarveTechnique = new Technique
            {
				Id = 5,
                Name = "Carve",
                Primary = MaterialType.wood,
                Secondary = MaterialType.leather,
                Tertiary = MaterialType.gem
            };
            Techniques.Add(CarveTechnique);
			var WarpTechnique = new Technique
            {
				Id = 6,
                Name = "Warp",
                Primary = MaterialType.wood,
                Secondary = MaterialType.cloth,
                Tertiary = MaterialType.leather
            };
            Techniques.Add(WarpTechnique);
        }

        public List<Technique> Techniques { get; set; } 
    }
}
