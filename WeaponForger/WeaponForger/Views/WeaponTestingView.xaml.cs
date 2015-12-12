// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 12/10/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using WeaponForger.Models;
using WeaponForger.ViewModels;
using Xamarin.Forms;

namespace WeaponForger.Views
{
    public partial class WeaponTestingView : ContentPage
    {
        public WeaponTestingView(Weapon weapon)
        {
            InitializeComponent();
            BindingContext = new WeaponTestingViewModel(Navigation, weapon);
        }
    }
}