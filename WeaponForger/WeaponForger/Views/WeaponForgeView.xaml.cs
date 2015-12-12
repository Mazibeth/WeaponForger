// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 12/01/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using WeaponForger.Models;
using WeaponForger.ViewModels;
using Xamarin.Forms;

namespace WeaponForger.Views
{
    public partial class WeaponForge : ContentPage
    {
        public WeaponForge()
        {
            InitializeComponent();
            BindingContext = new WeaponForgeViewModel(Navigation);
        }

        public WeaponForge(Weapon weapon)
        {
            InitializeComponent();
            BindingContext = new WeaponForgeViewModel(Navigation, weapon);
        }
    }
}