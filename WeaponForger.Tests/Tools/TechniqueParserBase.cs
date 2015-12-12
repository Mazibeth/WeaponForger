using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WeaponForger.Enums;
using WeaponForger.Models;

namespace WeaponForger.Tests.Tools
{
    public partial class TechniqueParser
    {
        public TechniqueParser()
        {
            Techniques = new List<Technique>();

            FileName = string.Format("{0}\\Data\\Technique List.csv",
                Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName);

            var data = File.ReadAllLines(FileName)
                .Skip(1)
                .Select(x => x.Split(','));

            foreach (var stringse in data)
            {
                var Technique = new Technique
                {
                    Id = Convert.ToInt32(stringse[0]),
                    Name = stringse[1],
                    Primary = (MaterialType) Enum.Parse(typeof (MaterialType), stringse[2].ToLower()),
                    Secondary = (MaterialType) Enum.Parse(typeof (MaterialType), stringse[3].ToLower()),
                    Tertiary = (MaterialType) Enum.Parse(typeof (MaterialType), stringse[4].ToLower())
                };
                Techniques.Add(Technique);
            }

            for (var i = 0; i < Techniques.Count; i++)
            {
                Techniques[i].Id = i + 1;
            }
        }

        public string FileName { get; set; }
        public List<Technique> Techniques { get; set; }
    }
}