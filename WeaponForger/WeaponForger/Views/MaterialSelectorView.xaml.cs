// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 12/07/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using WeaponForger.Models;
using WeaponForger.ViewModels;
using Xamarin.Forms;

namespace WeaponForger.Views
{
    public partial class MaterialSelectorView : ContentPage
    {
        public MaterialSelectorView(Weapon weapon, Material material)
        {
            InitializeComponent();
            BindingContext = new MaterialSelectorViewModel(Navigation, weapon, material);
        }
    }
}