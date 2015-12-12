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

        public Weapon Weapon { get; set; }
        public Material Material { get; set; }
        public Material SelectedMaterial { get; set; }
        public List<Material> MaterialList { get; set; }
        public MaterialLibrary MaterialLibrary { get; set; }
        public INavigation Navigation { get; set; }
        public Command SelectCommand { get; set; }

        public async void SelectMaterial()
        {
            if (SelectedMaterial != null)
            {
                Weapon.Materials[Weapon.Materials.IndexOf(Material)] = SelectedMaterial;
                await Navigation.PushAsync(new WeaponForge(Weapon));
            }
        }
    }
}