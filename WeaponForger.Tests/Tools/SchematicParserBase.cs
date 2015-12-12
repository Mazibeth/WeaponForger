using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using WeaponForger.Models;

namespace WeaponForger.Tests.Tools
{
    public partial class SchematicParser
    {
        public SchematicParser()
        {
            Schematics = new List<Schematic>();
            FileName = string.Format("{0}\\Data\\Schematics List.csv",
                Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName);

            var data = File.ReadAllLines(FileName)
                .Skip(1)
                .Select(x => x.Split(','));

            foreach (var stringse in data)
            {
                var Schematic = new Schematic
                {
                    Id = Convert.ToInt32(stringse[0]),
                    Name = stringse[1],
                    Slot = Regex.Replace(stringse[2].ToLower(), @"\s+""", "").ToCharArray()
                };
                Debug.WriteLine(string.Concat(Schematic.Slot));
                Schematics.Add(Schematic);
            }
        }

        public string FileName { get; set; }
        public List<Schematic> Schematics { get; set; }
    }
}