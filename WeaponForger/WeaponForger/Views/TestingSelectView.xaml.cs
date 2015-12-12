// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 12/11/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using WeaponForger.ViewModels;
using Xamarin.Forms;

namespace WeaponForger.Views
{
    public partial class TestingSelectView : ContentPage
    {
        public TestingSelectView()
        {
            InitializeComponent();
            BindingContext = new TestingSelectViewModel(Navigation);
        }
    }
}