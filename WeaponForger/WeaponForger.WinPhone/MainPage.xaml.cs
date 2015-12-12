// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 09/14/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

namespace WeaponForger.WinPhone
{
    public partial class MainPage : FormsApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

            Forms.Init();
            LoadApplication(new WeaponForger.App());
        }
    }
}