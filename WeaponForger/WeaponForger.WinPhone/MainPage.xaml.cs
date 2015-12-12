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