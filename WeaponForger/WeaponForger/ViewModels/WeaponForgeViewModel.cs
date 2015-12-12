using System;
using System.Diagnostics;
using System.Linq;
using WeaponForger.Data;
using WeaponForger.Models;
using WeaponForger.Views;
using Xamarin.Forms;

namespace WeaponForger.ViewModels
{
    public class WeaponForgeViewModel
    {
        public WeaponForgeViewModel(INavigation navigation)
        {
            Navigation = navigation;
            DBContext = new WeaponForgerDatabase();

            Weapon = new Weapon();
            TechniqueLibrary = new TechniqueLibrary();
            SchematicLibrary = new SchematicLibrary();
            MaterialLibrary = new MaterialLibrary();
            
            MaterialTappedCommand = new Command(MaterialTapped);
            ReforgeCommand = new Command(Reforge);
            ForgeCommand = new Command(ForgeWeapon);

            SelectedTechnique = TechniqueLibrary.Techniques.First(x => x.Name == "Cast");
            SelectedSchematic = SchematicLibrary.Schematics.First(x => x.Name == "Dagger");

            #region Default Weapon

            Weapon.Name = "Simple Dagger";
            Weapon.Technique = TechniqueLibrary.Techniques.First(x => x.Name == "Cast");
            Weapon.Schematic = SchematicLibrary.Schematics.First(x => x.Name == "Dagger");

            foreach (var t in Weapon.Schematic.Slot)
            {
                if (t == 'p')
                {
                    Weapon.Materials.Add(MaterialLibrary.MaterialsList.First(x => x.Name == "Iron"));
                }
                else if (t == 's')
                {
                    Weapon.Materials.Add(MaterialLibrary.MaterialsList.First(x => x.Name == "Yew"));
                }
                else if (t == 't')
                {
                    Weapon.Materials.Add(MaterialLibrary.MaterialsList.First(x => x.Name == "Quartz"));
                }
            }

            #endregion
        }

        public WeaponForgeViewModel(INavigation navigation, Weapon weapon)
        {
            Navigation = navigation;
            DBContext = new WeaponForgerDatabase();

            Weapon = weapon;
            TechniqueLibrary = new TechniqueLibrary();
            SchematicLibrary = new SchematicLibrary();
            MaterialLibrary = new MaterialLibrary();

            MaterialTappedCommand = new Command(MaterialTapped);
            ReforgeCommand = new Command(Reforge);
            ForgeCommand = new Command(ForgeWeapon, ForgeEnabled);


            SelectedTechnique = TechniqueLibrary.Techniques.First(x => x.Name == Weapon.Technique.Name);
            SelectedSchematic = SchematicLibrary.Schematics.First(x => x.Name == Weapon.Schematic.Name);
        }

        public Command MaterialTappedCommand { get; private set; }
        public Command ReforgeCommand { get; }
        public Command ForgeCommand { get; }
        public Weapon Weapon { get; set; }
        public WeaponForgerDatabase DBContext { get; set; }
        public MaterialLibrary MaterialLibrary { get; set; }
        public SchematicLibrary SchematicLibrary { get; set; }
        public TechniqueLibrary TechniqueLibrary { get; set; }
        private Schematic _selectedSchematic { get; set; }
        private Technique _selectedTechnique { get; set; }
        private Material _selectedMaterial { get; set; }

        public Material SelectedMaterial
        {
            get { return _selectedMaterial; }
            set
            {
                _selectedMaterial = value;
                if (_selectedMaterial != null)
                {
                    Navigation.PushAsync(new MaterialSelectorView(Weapon, _selectedMaterial));
                }
            }
        }

        public Schematic SelectedSchematic
        {
            get { return _selectedSchematic; }
            set
            {
                try
                {
                    _selectedSchematic = value;
                    //ReforgeCommand.ChangeCanExecute();
                    ForgeCommand.ChangeCanExecute();
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                    throw;
                }
            }
        }

        public Technique SelectedTechnique
        {
            get { return _selectedTechnique; }
            set
            {
                try
                {
                    _selectedTechnique = value;
                    //ReforgeCommand.ChangeCanExecute();
                    ForgeCommand.ChangeCanExecute();
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                    throw;
                }
            }
        }

        public INavigation Navigation { get; set; }

        private void Reforge()
        {
            if (SelectedSchematic == null || SelectedTechnique == null)
            {
                return;
            }

            Weapon.Materials.Clear();

            Weapon.Technique = SelectedTechnique;
            Weapon.Schematic = SelectedSchematic;

            foreach (var t in Weapon.Schematic.Slot)
            {
                if (t == 'p')
                {
                    Weapon.Materials.Add(new Material {Name = "Empty", Type = Weapon.Technique.Primary});
                }
                else if (t == 's')
                {
                    Weapon.Materials.Add(new Material {Name = "Empty", Type = Weapon.Technique.Secondary});
                }
                else if (t == 't')
                {
                    Weapon.Materials.Add(new Material {Name = "Empty", Type = Weapon.Technique.Tertiary});
                }
            }
        }

        private bool ForgeEnabled()
        {
            if (Weapon.Materials.Any(material => material.Name == "Empty"))
            {
                return false;
            }
            return DBContext != null && SelectedTechnique != null && SelectedSchematic != null;
        }

        private async void MaterialTapped()
        {
            await Navigation.PushAsync(new MaterialSelectorView(Weapon, SelectedMaterial));
        }

        private async void ForgeWeapon()
        {
            try
            {
                if (DBContext != null &&
                    !Weapon.Materials.Contains(Weapon.Materials.FirstOrDefault(x => x.Name == "Empty")))
                {
                    if (!DBContext.GetWeapons().Any())
                    {
                        Weapon.Id = 0;
                    }
                    else if (Weapon.Id == null)
                    {
                        Weapon.Id = DBContext.GetWeapons().Last().Id + 1;
                    }
                    Weapon.GenerateWeapon();
                    DBContext.Database.InsertOrReplace(Weapon);
                    await Navigation.PopToRootAsync();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }
    }
}