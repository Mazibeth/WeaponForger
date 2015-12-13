// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 12/02/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

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
        /// <summary>
        /// Initializes a new instance of the <see cref="WeaponForgeViewModel"/> class.
        /// </summary>
        /// <param name="navigation">The navigation.</param>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="WeaponForgeViewModel"/> class.
        /// </summary>
        /// <param name="navigation">The navigation.</param>
        /// <param name="weapon">The weapon.</param>
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

        #region Fields

        private Schematic _selectedSchematic { get; set; }
        private Technique _selectedTechnique { get; set; }
        private Material _selectedMaterial { get; set; }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the material tapped command.
        /// </summary>
        /// <value>
        /// The material tapped command.
        /// </value>
        public Command MaterialTappedCommand { get; private set; }

        /// <summary>
        /// Gets the reforge command.
        /// </summary>
        /// <value>
        /// The reforge command.
        /// </value>
        public Command ReforgeCommand { get; }

        /// <summary>
        /// Gets the forge command.
        /// </summary>
        /// <value>
        /// The forge command.
        /// </value>
        public Command ForgeCommand { get; }

        /// <summary>
        /// Gets or sets the weapon.
        /// </summary>
        /// <value>
        /// The weapon.
        /// </value>
        public Weapon Weapon { get; set; }

        /// <summary>
        /// Gets or sets the database context.
        /// </summary>
        /// <value>
        /// The database context.
        /// </value>
        public WeaponForgerDatabase DBContext { get; set; }

        /// <summary>
        /// Gets or sets the material library.
        /// </summary>
        /// <value>
        /// The material library.
        /// </value>
        public MaterialLibrary MaterialLibrary { get; set; }

        /// <summary>
        /// Gets or sets the schematic library.
        /// </summary>
        /// <value>
        /// The schematic library.
        /// </value>
        public SchematicLibrary SchematicLibrary { get; set; }

        /// <summary>
        /// Gets or sets the technique library.
        /// </summary>
        /// <value>
        /// The technique library.
        /// </value>
        public TechniqueLibrary TechniqueLibrary { get; set; }

        /// <summary>
        /// Gets or sets the selected material.
        /// </summary>
        /// <value>
        /// The selected material.
        /// </value>
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

        /// <summary>
        /// Gets or sets the selected schematic.
        /// </summary>
        /// <value>
        /// The selected schematic.
        /// </value>
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

        /// <summary>
        /// Gets or sets the selected technique.
        /// </summary>
        /// <value>
        /// The selected technique.
        /// </value>
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

        /// <summary>
        /// Gets or sets the navigation.
        /// </summary>
        /// <value>
        /// The navigation.
        /// </value>
        public INavigation Navigation { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Reforges this instance.
        /// </summary>
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

        /// <summary>
        /// Forges the enabled.
        /// </summary>
        /// <returns></returns>
        private bool ForgeEnabled()
        {
            if (Weapon.Materials.Any(material => material.Name == "Empty"))
            {
                return false;
            }
            return DBContext != null && SelectedTechnique != null && SelectedSchematic != null;
        }

        /// <summary>
        /// Materials the tapped.
        /// </summary>
        private async void MaterialTapped()
        {
            await Navigation.PushAsync(new MaterialSelectorView(Weapon, SelectedMaterial));
        }

        /// <summary>
        /// Forges the weapon.
        /// </summary>
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
                    await Navigation.PushAsync(new ForgedView(Weapon));
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        #endregion

    }
}