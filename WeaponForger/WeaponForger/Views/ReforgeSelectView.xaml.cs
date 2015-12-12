// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 12/08/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using WeaponForger.ViewModels;
using Xamarin.Forms;

namespace WeaponForger.Views
{
    public partial class ReforgeSelectView : ContentPage
    {
        public ReforgeSelectView()
        {
            InitializeComponent();
            BindingContext = new ReforgeSelectViewModel(Navigation);
        }
    }
}