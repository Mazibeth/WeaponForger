// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 12/07/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using System.Collections.Generic;
using System.Linq;
using WeaponForger.Data;
using WeaponForger.Models;
using WeaponForger.Views;
using Xamarin.Forms;

namespace WeaponForger.ViewModels
{
    public class MaterialSelectorViewModel
    {
        public MaterialSelectorViewModel(INavigation navigation, Weapon weapon, Material material)
        {
            Navigation = navigation;
            Weapon = weapon;
            Material = material;

            MaterialLibrary = new MaterialLibrary();

            SelectCommand = new Command(SelectMaterial);

            MaterialList = MaterialLibrary.MaterialsList.Where(x => x.Type == Material.Type).ToList();
        }

        #region Properties

        /// <summary>
        /// Gets or sets the weapon.
        /// </summary>
        /// <value>
        /// The weapon.
        /// </value>
        public Weapon Weapon { get; set; }

        /// <summary>
        /// Gets or sets the material.
        /// </summary>
        /// <value>
        /// The material.
        /// </value>
        public Material Material { get; set; }

        /// <summary>
        /// Gets or sets the selected material.
        /// </summary>
        /// <value>
        /// The selected material.
        /// </value>
        public Material SelectedMaterial { get; set; }

        /// <summary>
        /// Gets or sets the material list.
        /// </summary>
        /// <value>
        /// The material list.
        /// </value>
        public List<Material> MaterialList { get; set; }

        /// <summary>
        /// Gets or sets the material library.
        /// </summary>
        /// <value>
        /// The material library.
        /// </value>
        public MaterialLibrary MaterialLibrary { get; set; }

        /// <summary>
        /// Gets or sets the navigation.
        /// </summary>
        /// <value>
        /// The navigation.
        /// </value>
        public INavigation Navigation { get; set; }

        /// <summary>
        /// Gets or sets the select command.
        /// </summary>
        /// <value>
        /// The select command.
        /// </value>
        public Command SelectCommand { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Selects the material.
        /// </summary>
        public async void SelectMaterial()
        {
            if (SelectedMaterial != null)
            {
                Weapon.Materials[Weapon.Materials.IndexOf(Material)] = SelectedMaterial;
                await Navigation.PushAsync(new WeaponForge(Weapon));
            }
        }

        #endregion

    }
}