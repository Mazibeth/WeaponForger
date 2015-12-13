// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 12/12/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using WeaponForger.Models;
using WeaponForger.ViewModels;
using Xamarin.Forms;

namespace WeaponForger.Views
{
    public partial class ForgedView : ContentPage
    {
        public ForgedView(Weapon weapon)
        {
            InitializeComponent();
            BindingContext = new ForgedViewModel(Navigation, weapon);
        }
    }
}