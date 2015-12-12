using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WeaponForger.Enums;
using WeaponForger.Models;

namespace WeaponForger.Tests.Tools
{
    public partial class MaterialParser
    {
        public MaterialParser()
        {
            Materials = new List<Material>();

            FileName = string.Format("{0}\\Data\\Materials List.csv",
                Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName);

            var data = File.ReadAllLines(FileName)
                .Skip(1)
                .Select(x => x.Split(','));

            foreach (var stringse in data)
            {
                var Material = new Material
                {
                    Id = Convert.ToInt32(stringse[0]),
                    Name = stringse[1],
                    Type = (MaterialType) Enum.Parse(typeof (MaterialType), stringse[2].ToLower()),
                    Weight = Convert.ToDouble(stringse[3]),
                    Hardness = Convert.ToDouble(stringse[4]),
                    Resistance = (Convert.ToDouble(stringse[3]) + Convert.ToDouble(stringse[4]))/2
                };
                Materials.Add(Material);
            }
        }

        public string FileName { get; set; }
        public List<Material> Materials { get; set; }
    }
}