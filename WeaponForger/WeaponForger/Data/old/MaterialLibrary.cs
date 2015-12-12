
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
                Weight = 707.96,
                Hardness = 1.5,
                Resistance = 21.3,
                Type = MaterialType.metal
            };
            MaterialsList.Add(LeadMaterial);
        }

        public List<Material> MaterialsList { get; set; } 
    }
}
