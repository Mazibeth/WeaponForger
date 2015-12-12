// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 10/31/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using SQLite;
using WeaponForger.Interfaces;
using WeaponForger.Models;
using Xamarin.Forms;

namespace WeaponForger.Data
{
    public class WeaponForgerDatabase
    {
        public WeaponForgerDatabase()
        {
            MaterialLibrary = new MaterialLibrary();
            SchematicLibrary = new SchematicLibrary();
            TechniqueLibrary = new TechniqueLibrary();

            Database = DependencyService.Get<ISQLite>().GetConnection();
            try
            {
                Database.CreateTable<Weapon>();
            }
            catch (Exception e)
            {
                Debug.WriteLine("DATABASE CREATE FAILURE: {0}", e.Message);
                throw;
            }
        }

        public SQLiteConnection Database { get; set; }
        public MaterialLibrary MaterialLibrary { get; set; }
        public SchematicLibrary SchematicLibrary { get; set; }
        public TechniqueLibrary TechniqueLibrary { get; set; }
        //Weapons
        public IEnumerable<Weapon> GetWeapons()
        {
            var Weapons = (from i in Database.Table<Weapon>() select i).ToList();

            foreach (var weapon in Weapons)
            {
                weapon.Materials = new ObservableCollection<Material>();
                var IDs = weapon.MaterialIds.Split(',');

                foreach (var id in IDs)
                {
                    if (id != string.Empty)
                    {
                        weapon.Materials.Add(MaterialLibrary.MaterialsList.First(x => x.Id == Convert.ToInt32(id)));
                    }
                }

                weapon.Schematic = SchematicLibrary.Schematics.First(x => x.Id == weapon.SchematicId);
                weapon.Technique = TechniqueLibrary.Techniques.First(x => x.Id == weapon.TechniqueId);
            }

            return Weapons;
        }

        public Weapon GetWeapon(int? id)
        {
            var weapon = Database.Table<Weapon>().FirstOrDefault(x => x.Id == id);

            weapon.Materials = new ObservableCollection<Material>();
            var IDs = weapon.MaterialIds.Split(',');

            foreach (var ID in IDs)
            {
                if (ID != string.Empty)
                {
                    weapon.Materials.Add(MaterialLibrary.MaterialsList.First(x => x.Id == Convert.ToInt32(ID)));
                }
            }

            return weapon;
        }

        public int DeleteWeapon(int? id)
        {
            return Database.Delete<Weapon>(id);
        }
    }
}